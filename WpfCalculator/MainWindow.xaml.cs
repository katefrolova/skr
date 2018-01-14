using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Calc;

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<OperationBase> history = new List<OperationBase>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = 0.0;
            try
            {
            a = double.Parse(textboxA.Text);

            }
            catch(Exception t)
            {
                MessageBox.Show(" Argument A " + t.Message );
                return;
            }

            var b = 0.0;
            try
            {
                b = double.Parse(textboxB.Text);

            }
            catch (Exception t)
            {
                MessageBox.Show(" Argument B " + t.Message);
                return;
            }


            var operation = CreateOperation();

            operation.A = a;
            operation.B = b;

            try
            {
                operation.Calculate();

                textboxResult.Text = operation.Result.Value.ToString();
                history.Add(operation);
                // HistoryBox.Text = history.Count.ToString();
                HistoryBox.Text = CreateHistoryText();
            }
            catch (Exception ee)
            {
                textboxResult.Text = ee.Message;
            }
            
        }

        private OperationBase CreateOperation()
        {
            if (addButton.IsChecked == true)
                return new AddOperation();
            if (subButton.IsChecked == true)
                return new SubOperation();
            if (multButton.IsChecked == true)
                return new MultOperation();
            if (divButton.IsChecked == true)
                return new DivOperation();
            if (powButton.IsChecked == true)
                return new PowOperation();
            throw new NotImplementedException();
        }

        private void HistoryBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        /// <summary>
        /// Формирует полный текст истории
        /// </summary>
        /// <returns></returns>
        private string CreateHistoryText()
        {
 
            var result = "";
            int n = 1;
            foreach (var op in history)
            {
                //var s = op.A + "+" + op.B + "=" + op.Result.Value;
                result += n +")  "  +  op + Environment.NewLine;
                n++;
            }
            return result;
        }
    }


}
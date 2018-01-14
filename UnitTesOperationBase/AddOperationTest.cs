using Calc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesOperationBase
{
    [TestClass]
    public class AddOperationTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            var operation = new AddOperation
            {
                A = 2,
                B = 4
            };

            operation.Calculate();
            Assert.IsTrue(operation.Result!=null);
            Assert.IsTrue(operation.Result.Value == 6);
        }
    }
}

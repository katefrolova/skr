using Calc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesOperationBase
{
    [TestClass]
    public class MultOperationTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            var operation = new MultOperation
            {
                A = 2,
                B = 3.5
            };
            operation.Calculate();
            Assert.IsTrue(operation.Result != null);
            Assert.IsTrue(operation.Result.Value == 7);
        }
    }
}

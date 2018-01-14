using Calc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesOperationBase
{
    [TestClass]
    public class PowOperationTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            var operation = new PowOperation()
            {
                A = 2,
                B = 3
            };
            operation.Calculate();
            Assert.IsTrue(operation.Result != null);
            Assert.IsTrue(operation.Result == 8);

        }
    }
}

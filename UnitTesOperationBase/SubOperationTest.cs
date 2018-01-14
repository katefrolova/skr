using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;

namespace UnitTesOperationBase
{
    [TestClass]
    public class SubOperationTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            var operation = new SubOperation
            {
                A = 4,
                B = 2
            };
            operation.Calculate();
            Assert.IsTrue(operation.Result != null);
            Assert.IsTrue(operation.Result.Value== -2);
        }
    }
}

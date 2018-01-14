using System;
using Calc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesOperationBase
{
    [TestClass]
    public class DivOperationTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            var operation = new DivOperation
            {
                A = 2,
                B = 8
            };
            operation.Calculate();
            Assert.IsTrue(operation.Result != null);
            Assert.IsTrue(operation.Result.Value == 0.25);
        }

        [TestMethod]
        public void ZeroDevisionTest()
        {
            try
            {
                var operation = new DivOperation
                {
                    A = 2,
                    B = 0
                };
                operation.Calculate();
                throw new AssertFailedException("Деление на ноль невозможно");
            }
            catch(ArgumentException)
            {

            }

        }


    }
}

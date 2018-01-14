using System;

namespace Calc
{
    public class DivOperation:OperationBase
    {
        public override void Calculate()
        {
            if (B == 0) 
                throw new ArgumentException("Деление на ноль невозможно");  
            Result = A / B;

        }
        public override string ToString()
        {
            return A + " / " + B + " = " + Result.Value;
        }

    }
}

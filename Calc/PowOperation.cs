using System;

namespace Calc
{
   public class PowOperation: OperationBase
    {
        public override void Calculate()
        {
            Result = Math.Pow(A, B);
        }
        public override string ToString()
        {
            return A + " ^ " + B + " = " + Result.Value;
        }
    }
}

namespace Calc
{
    public class SubOperation:OperationBase
    {
        public override void Calculate()
        {
            Result = B - A;
          
        }
        public override string ToString()
        {
            return A + " - " + B + " = " + Result.Value;
        }
    }
}

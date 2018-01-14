namespace Calc
{
    public class MultOperation: OperationBase
    {
        public override void Calculate()
        {
            Result = A * B;
        }
        public override string ToString()
        {
            return A + " * " + B + " = " + Result.Value;
        }
    }
}

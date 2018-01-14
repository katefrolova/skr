namespace Calc
{
    public class AddOperation: OperationBase
    {
        public override void Calculate()
        {
            Result = A + B;  

           // throw new NotImplementedException();
        }

        public override string ToString()
        {
            return A + " + " + B + " = " + Result.Value;
        }
    }
}

namespace Calc
{
    /// <summary>
    /// Тип для мат расчетотв
    /// </summary>
    public abstract class OperationBase
    {
        /// <summary>
        /// vvod A
        /// 
        /// </summary>
        public double A { get; set;  }

        /// <summary>
        /// vvod B
        /// </summary>
        public double B {  get;set; }

        /// <summary>
        /// Result
        /// </summary>
        public double? Result { get; set; }

        /// <summary>
        /// Calc
        /// </summary>
        public abstract void Calculate();
    }
}

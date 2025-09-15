using System;


namespace F10Y.L0025
{
    public class CloneOptionsOperator : ICloneOptionsOperator
    {
        #region Infrastructure

        public static ICloneOptionsOperator Instance { get; } = new CloneOptionsOperator();


        private CloneOptionsOperator()
        {
        }

        #endregion
    }
}

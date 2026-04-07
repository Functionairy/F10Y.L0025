using System;


namespace F10Y.L0025
{
    public class PushOptionsOperator : IPushOptionsOperator
    {
        #region Infrastructure

        public static IPushOptionsOperator Instance { get; } = new PushOptionsOperator();


        private PushOptionsOperator()
        {
        }

        #endregion
    }
}

using System;


namespace F10Y.L0025
{
    public class FetchOptionsOperator : IFetchOptionsOperator
    {
        #region Infrastructure

        public static IFetchOptionsOperator Instance { get; } = new FetchOptionsOperator();


        private FetchOptionsOperator()
        {
        }

        #endregion
    }
}

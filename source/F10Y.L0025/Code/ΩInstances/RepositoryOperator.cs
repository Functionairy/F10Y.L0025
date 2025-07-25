using System;


namespace F10Y.L0025
{
    public class RepositoryOperator : IRepositoryOperator
    {
        #region Infrastructure

        public static IRepositoryOperator Instance { get; } = new RepositoryOperator();


        private RepositoryOperator()
        {
        }

        #endregion
    }
}

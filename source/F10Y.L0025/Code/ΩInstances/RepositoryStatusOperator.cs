using System;


namespace F10Y.L0025
{
    public class RepositoryStatusOperator : IRepositoryStatusOperator
    {
        #region Infrastructure

        public static IRepositoryStatusOperator Instance { get; } = new RepositoryStatusOperator();


        private RepositoryStatusOperator()
        {
        }

        #endregion
    }
}

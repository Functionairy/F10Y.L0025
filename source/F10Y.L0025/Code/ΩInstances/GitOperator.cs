using System;


namespace F10Y.L0025
{
    public class GitOperator : IGitOperator
    {
        #region Infrastructure

        public static IGitOperator Instance { get; } = new GitOperator();


        private GitOperator()
        {
        }

        #endregion
    }
}

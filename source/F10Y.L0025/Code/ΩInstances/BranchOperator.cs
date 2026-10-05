using System;


namespace F10Y.L0025
{
    public class BranchOperator : IBranchOperator
    {
        #region Infrastructure

        public static IBranchOperator Instance { get; } = new BranchOperator();


        private BranchOperator()
        {
        }

        #endregion
    }
}

using System;


namespace F10Y.L0025
{
    public class BranchNames : IBranchNames
    {
        #region Infrastructure

        public static IBranchNames Instance { get; } = new BranchNames();


        private BranchNames()
        {
        }

        #endregion
    }
}

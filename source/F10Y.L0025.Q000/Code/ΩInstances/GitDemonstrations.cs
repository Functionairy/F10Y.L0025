using System;


namespace F10Y.L0025.Q000
{
    public class GitDemonstrations : IGitDemonstrations
    {
        #region Infrastructure

        public static IGitDemonstrations Instance { get; } = new GitDemonstrations();


        private GitDemonstrations()
        {
        }

        #endregion
    }
}

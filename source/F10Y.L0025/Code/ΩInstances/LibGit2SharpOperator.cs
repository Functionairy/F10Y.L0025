using System;


namespace F10Y.L0025
{
    public class LibGit2SharpOperator : ILibGit2SharpOperator
    {
        #region Infrastructure

        public static ILibGit2SharpOperator Instance { get; } = new LibGit2SharpOperator();


        private LibGit2SharpOperator()
        {
        }

        #endregion
    }
}

using System;


namespace F10Y.L0025
{
    public static class Instances
    {
        public static IBranchNames BranchNames => L0025.BranchNames.Instance;
        public static ICloneOptionsOperator CloneOptionsOperator => L0025.CloneOptionsOperator.Instance;
        public static ICredentialsOperator CredentialsOperator => L0025.CredentialsOperator.Instance;
        public static IFetchOptionsOperator FetchOptionsOperator => L0025.FetchOptionsOperator.Instance;
        public static ILibGit2SharpOperator LibGit2SharpOperator => L0025.LibGit2SharpOperator.Instance;
        public static L0000.INullOperator NullOperator => L0000.NullOperator.Instance;
        public static L0000.IPathOperator PathOperator => L0000.PathOperator.Instance;
        public static IRemoteNames RemoteNames => L0025.RemoteNames.Instance;
        public static IRemoteOperator RemoteOperator => L0025.RemoteOperator.Instance;
        public static IRepositoryOperator RepositoryOperator => L0025.RepositoryOperator.Instance;
        public static IValues Values => L0025.Values.Instance;
    }
}
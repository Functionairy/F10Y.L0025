using System;
using System.Threading.Tasks;

using LibGit2Sharp;

using F10Y.T0002;


namespace F10Y.L0025
{
    /// <summary>
    /// LibGit2Sharp-based GitOperator library.
    /// </summary>
    [FunctionsMarker]
    public partial interface IGitOperator
    {
        public void In_RepositoryContext(
            string repositoryDirectoryPath,
            Action<Repository> repositoryAction)
            => Instances.RepositoryOperator.In_RepositoryContext(
                repositoryDirectoryPath,
                repositoryAction);

        public TOut In_RepositoryContext<TOut>(
            string repositoryDirectoryPath,
            Func<Repository, TOut> repositoryAction)
            => Instances.RepositoryOperator.In_RepositoryContext(
                repositoryDirectoryPath,
                repositoryAction);

        public Task In_RepositoryContext<TOut>(
            string repositoryDirectoryPath,
            Func<Repository, Task> repositoryAction)
            => Instances.RepositoryOperator.In_RepositoryContext(
                repositoryDirectoryPath,
                repositoryAction);

        public Task<TOut> In_RepositoryContext<TOut>(
            string repositoryDirectoryPath,
            Func<Repository, Task<TOut>> repositoryAction)
            => Instances.RepositoryOperator.In_RepositoryContext(
                repositoryDirectoryPath,
                repositoryAction);
    }
}

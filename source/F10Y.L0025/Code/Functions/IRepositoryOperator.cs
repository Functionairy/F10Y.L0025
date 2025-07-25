using System;
using System.Threading.Tasks;

using LibGit2Sharp;

using F10Y.T0002;


namespace F10Y.L0025
{
    [FunctionsMarker]
    public partial interface IRepositoryOperator
    {
        public Repository From(string repositoryDirectoryPath)
        {
            var output = new Repository(repositoryDirectoryPath);
            return output;
        }

        public void In_RepositoryContext(
            string repositoryDirectoryPath,
            Action<Repository> repositoryAction)
        {
            using var repository = this.From(repositoryDirectoryPath);

            repositoryAction(repository);
        }

        public TOut In_RepositoryContext<TOut>(
            string repositoryDirectoryPath,
            Func<Repository, TOut> repositoryAction)
        {
            using var repository = this.From(repositoryDirectoryPath);

            var output = repositoryAction(repository);
            return output;
        }

        public async Task In_RepositoryContext<TOut>(
            string repositoryDirectoryPath,
            Func<Repository, Task> repositoryAction)
        {
            using var repository = this.From(repositoryDirectoryPath);

            // Required to await inside the method since the repository will be disposed.
            await repositoryAction(repository);
        }

        public async Task<TOut> In_RepositoryContext<TOut>(
            string repositoryDirectoryPath,
            Func<Repository, Task<TOut>> repositoryAction)
        {
            using var repository = this.From(repositoryDirectoryPath);

            // Required to await inside the method since the repository will be disposed.
            var output = await repositoryAction(repository);
            return output;
        }
    }
}

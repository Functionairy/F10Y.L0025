using System;
using System.Threading.Tasks;

using LibGit2Sharp;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0025
{
    /// <summary>
    /// LibGit2Sharp-based GitOperator library.
    /// </summary>
    [FunctionsMarker]
    public partial interface IGitOperator
    {
        /// <inheritdoc cref="ILibGit2SharpOperator.Clone_NonIdempotent(string, string, string, string)" path="/summary"/>
        /// <inheritdoc cref="ILibGit2SharpOperator.Clone_NonIdempotent(string, string, string, string)" path="/returns"/>
        /// <remarks>
        /// Quality-of-life forward for <see cref="ILibGit2SharpOperator.Clone_NonIdempotent(string, string, string, string)"/>.
        /// </remarks>
        [InstanceIdentity("E42F0A64-ABC8-4FB8-88CD-C331BA196A9C")]
        public string Clone_NonIdempotent(
            string sourceUrl,
            string repositoryDirectoryPath,
            string username,
            string password)
        {
            var output = Instances.LibGit2SharpOperator.Clone_NonIdempotent(
                sourceUrl,
                repositoryDirectoryPath,
                username,
                password);

            return output;
        }

        [InstanceIdentity("5211E6C4-8EF9-4624-9DD2-DFA6DF2C059D")]
        public void Fetch_Remote(
            string repositoryDirectoryPath,
            string username,
            string password)
            => Instances.RepositoryOperator.Fetch_Origin(
                repositoryDirectoryPath,
                username,
                password);

        public string Get_RepositoryDirectoryPath(string path)
        {
            var wasFound = this.Has_Repository(
                path,
                out var repositoryDirectoryPath);

            if (!wasFound)
            {
                throw new Exception($"Not git repository was found for path:\n{path}");
            }

            return repositoryDirectoryPath;
        }

        [InstanceIdentity("DCDCF69B-AADA-49FE-A7B0-FF19D44D6A9C")]
        public string Get_Repository_RemoteUrl(string path_InRepositoryDirectory)
        {
            var output = Instances.LibGit2SharpOperator.Get_Repository_RemoteUrl(path_InRepositoryDirectory);
            return output;
        }

        public DateTimeOffset Get_LatestCommit_Timestamp(string repositoryDirectoryPath)
        {
            var output = Instances.LibGit2SharpOperator.Get_LatestCommit_Timestamp(repositoryDirectoryPath);
            return output;
        }

        /// <summary>
        /// Returns the <inheritdoc cref="Glossary.For_Directories.RepositoryDirectory" path="/name"/> path given a file or directory path from within the repository,
        /// or null if not found.
        /// </summary>
        public bool Has_Repository(
            string path,
            out string repositoryDirectoryPath_OrNotFound)
        {
            var wasFound_GitDirectory = this.Has_Repository_GitDirectory(
                path,
                out var gitDirectoryPath_OrNotFound);

            repositoryDirectoryPath_OrNotFound = wasFound_GitDirectory
                ? Instances.PathOperator.Get_ParentDirectoryPath_ForDirectory(gitDirectoryPath_OrNotFound)
                : Instances.Values.Repository_NotFound_DirectoryPath
                ;

            return wasFound_GitDirectory;
        }

        /// <summary>
        /// Returns the <inheritdoc cref="Glossary.For_Directories.RepositoryGitDirectory" path="/name"/> path, or null if no repository is found, or null if not found.
        /// </summary>
        public bool Has_Repository_GitDirectory(
            string path,
            out string gitDirectoryPath_OrNotFound)
        {
            var repositoryGitDirectoryPathWasFound = Instances.RepositoryOperator.Try_Discover_RepositoryDirectoryPath(
                path,
                out gitDirectoryPath_OrNotFound);

            return repositoryGitDirectoryPathWasFound;
        }

        [InstanceIdentity("580CEF21-1323-4B78-87A3-554C8432F944")]
        public bool Has_UnpulledChanges_WithoutFetch(string repositoryDirectoryPath)
            => Instances.RepositoryOperator.Has_UnpulledChanges_WithoutFetch(repositoryDirectoryPath);

        [InstanceIdentity("74DDE904-5EA5-4B24-A18C-5369CF08123D")]
        public bool Has_UnpushedChanges(string repositoryDirectoryPath)
            => Instances.LibGit2SharpOperator.Has_UnpushedChanges(repositoryDirectoryPath);

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

        /// <inheritdoc cref="IRepositoryOperator.Is_Repository(string)"/>
        [InstanceIdentity("F79C2884-3BF8-4F73-AB28-B011FD6CF371")]
        public bool Is_GitRepository(string directoryPath)
           => Instances.RepositoryOperator.Is_Repository(directoryPath);

        [InstanceIdentity("8E3D6176-CCEA-4537-AE25-A2F2299D2AC9")]
        public void Pull_WithoutFetch(
            string repositoryDirectoryPath,
            string authorName,
            string authorEmail)
            => Instances.RepositoryOperator.Pull_WithoutFetch_IsMerge(
                repositoryDirectoryPath,
                authorName,
                authorEmail);
    }
}

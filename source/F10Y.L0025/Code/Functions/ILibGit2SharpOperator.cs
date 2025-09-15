using System;

using LibGit2Sharp;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0025
{
    [FunctionsMarker]
    public partial interface ILibGit2SharpOperator
    {
        /// <summary>
        /// Non-idempotently clones a remote Git repository to a local directory path.
        /// An error will be thrown if the local directory is not empty, if it exists.
        /// </summary>
        /// <returns>
        /// The local repository .git directory path.
        /// </returns>
        [InstanceIdentity("D8F64EE6-D3B7-45BD-BAD8-8DAB98420E7B")]
        public string Clone_NonIdempotent(
            string sourceUrl,
            string repositoryDirectoryPath,
            string username,
            string password)
        {
            return Instances.RepositoryOperator.Clone_NonIdempotent(
                sourceUrl,
                repositoryDirectoryPath,
                username,
                password);
        }

        public DateTimeOffset Get_LatestCommit_Timestamp(Repository repository)
        {
            // Get the HEAD's latest commit
            var latestCommit = repository.Head.Tip;

            // Get the commit date (use Author.When for authorship date or Committer.When for commit date)
            var commitDate = latestCommit.Committer.When;
            return commitDate;
        }

        public DateTimeOffset Get_LatestCommit_Timestamp(string repositoryDirectoryPath)
        {
            using var repository = Instances.RepositoryOperator.From(repositoryDirectoryPath);

            var output = this.Get_LatestCommit_Timestamp(repository);
            return output;
        }

        string Get_Remote_Origin_Url(string pathInRepositoryDirectory)
        {
            var repositoryDirectoryPath = Instances.RepositoryOperator.Discover_RepositoryDirectoryPath(pathInRepositoryDirectory);

            using var repository = Instances.RepositoryOperator.Get_Repository(repositoryDirectoryPath);

            var originRemoteUrl = Instances.RepositoryOperator.Get_Remote_Origin_Url(repository);
            return originRemoteUrl;
        }

        /// <summary>
        /// Quality-of-life overload for <see cref="Get_Remote_Origin_Url(string)"/>.
        /// </summary>
        [InstanceIdentity("BD5F04FB-5290-4A73-8DF7-F72EAC4FC223")]
        public string Get_Repository_RemoteUrl(string path_InRepositoryDirectory)
        {
            var output = this.Get_Remote_Origin_Url(path_InRepositoryDirectory);
            return output;
        }

        [InstanceIdentity("0FACB49E-7A27-42B7-B678-473F16355789")]
        public bool Has_UnpushedChanges(string repositoryDirectoryPath)
            => Instances.RepositoryOperator.Has_UnpushedChanges(repositoryDirectoryPath);
    }
}

using System;
using System.Linq;
using System.Threading.Tasks;

using LibGit2Sharp;

using F10Y.L0000.Extensions;
using F10Y.T0006;


namespace F10Y.L0025.Q000
{
    [DemonstrationsMarker]
    public partial interface IGitDemonstrations
    {
        /// <summary>
        /// For a repository, get the list of commits, and list the files changed in each commit.
        /// </summary>
        public async Task List_FileChanges_ByCommit_ForRepository()
        {
            /// Inputs.
            var repositoryDirectoryPath =
                @"C:\Code\DEV\Git\GitHub\Functionairy\F10Y.L0000\"
                ;

            var output_TextFilePath = Instances.FilePaths.Output_TextFilePath;


            /// Run.
            async Task Internal(Repository repository)
            {
                var lines_ForOutput = Instances.EnumerableOperator.From($"Commits for repostory:\n\t{repository.Info.Path}\n")
                    .Append(repository.Head.Commits
                        .SelectMany(commit =>
                        {
                            var commit_Sha = commit.Id.Sha;

                            var commitTree = commit.Tree;

                            // First commit will have a null parent.
                            var parentTree = commit.Parents.FirstOrDefault()?.Tree;

                            var changes = repository.Diff.Compare<TreeChanges>(
                                parentTree,
                                commitTree);

                            var changes_Count = changes.Count;

                            var output = Instances.EnumerableOperator.From($"\n{commit_Sha}:{changes_Count} changes:")
                                .Append(changes
                                    .Select(change => $"{change.Path}")
                                )
                                ;

                            return output;
                        })
                    );

                await Instances.FileOperator.Write_Lines(
                    output_TextFilePath,
                    lines_ForOutput);
            }

            await Instances.RepositoryOperator.In_RepositoryContext(
                repositoryDirectoryPath,
                Internal);

            Instances.NotepadPlusPlusOperator.Open(output_TextFilePath);
        }
    }
}

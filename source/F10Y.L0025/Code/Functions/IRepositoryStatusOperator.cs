using System;
using System.Collections.Generic;
using System.Linq;

using LibGit2Sharp;

using F10Y.T0002;


namespace F10Y.L0025
{
    [FunctionsMarker]
    public partial interface IRepositoryStatusOperator
    {
        bool Any_Untracked(RepositoryStatus status)
            => status.Untracked.Any();

        /// <inheritdoc cref="RepositoryStatus.IsDirty"/>
        bool Get_IsDirty(RepositoryStatus status)
            => status.IsDirty;

        bool Has_UnpushedChanges(
            bool is_Dirty,
            bool any_Stashes,
            bool is_AheadOfRemote,
            bool any_Untracked)
            => false
                || is_Dirty
                || any_Stashes
                || is_AheadOfRemote
                || any_Untracked
                ;

        IEnumerable<string> Describe(UnpushedChangesResult result)
        {
            var lines_ForExplanation_Value = this.Describe_Contents(result);

            var output = result.Has_UnpushedChanges
                ? Instances.EnumerableOperator.From($"{result.Has_UnpushedChanges}, has-unpushed changes:")
                    .Append(lines_ForExplanation_Value)
                : Instances.EnumerableOperator.Empty<string>()
                ;

            return output;
        }

        IEnumerable<string> Describe_Contents(UnpushedChangesResult result)
        {
            var token_IsDirty = result.Is_Dirty
                ? Instances.Strings.dirty
                : Instances.Strings.Empty
                ;

            var token_AnyStashes = result.Any_Stashes
                ? Instances.Strings.stashes_Exist
                : Instances.Strings.Empty
                ;

            var token_IsAheadOfRemote = result.Is_AheadOfRemote
                ? Instances.Strings.unpushedCommits_Exist
                : Instances.Strings.Empty
                ;

            var token_AnyUntracked = result.Any_Untracked_AndNotIgnored
                ? Instances.Strings.untrackedAndNotIgnoredFiles_Exist
                : Instances.Strings.Empty
                ;

            var output = Instances.EnumerableOperator.From(
                token_IsDirty,
                token_AnyStashes,
                token_IsAheadOfRemote,
                token_AnyUntracked)
                .Where(Instances.StringOperator.Is_NotEmpty)
                ;

            return output;
        }
    }
}

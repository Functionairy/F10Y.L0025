using System;

using F10Y.T0004;


namespace F10Y.L0025
{
    /// <summary>
    /// The result of testing if a repository has any unpushed changes.
    /// </summary>
    [DataTypeMarker]
    public class UnpushedChangesResult
    {
        #region Static

        /// <summary>
        /// The result can be treated like a boolean.
        /// </summary>
        public static implicit operator bool(UnpushedChangesResult result)
            => result.Has_UnpushedChanges;

        #endregion


        /// <summary>
        /// The main result.
        /// </summary>
        public bool Has_UnpushedChanges { get; init; }

        /// <summary>
        /// Is the repository dirty.
        /// </summary>
        public bool Is_Dirty { get; init; }

        /// <summary>
        /// Does the repository have any pending stashes?
        /// </summary>
        public bool Any_Stashes { get; init; }

        /// <summary>
        /// Is the repository ahead of it's remote?
        /// </summary>
        public bool Is_AheadOfRemote { get; init; }

        /// <summary>
        /// Are there any untracked (and not ignored) files in the repository.
        /// </summary>
        public bool Any_Untracked_AndNotIgnored { get; init; }
    }
}

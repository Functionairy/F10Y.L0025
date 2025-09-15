using System;

using F10Y.T0001;


namespace F10Y.L0025
{
    public static partial class Glossary
    {
        [DocumentationsMarker]
        public static class For_Directories
        {
            /// <summary>
            /// <inheritdoc cref="RepositoryDirectory" path="/definition"/>
            /// </summary>
            /// <definition>A repository directory contains the <inheritdoc cref="RepositoryGitDirectory" path="/name"/> directory, as well as all the files in the repository.</definition>
            /// <name><i>repository directory</i></name>
            public static readonly object RepositoryDirectory;

            /// <summary>
            /// <inheritdoc cref="RepositoryGitDirectory" path="/definition"/>
            /// </summary>
            /// <definition>Every git repository has a ".git" directory containing all git-related files.</definition>
            /// <name><i>git directory</i></name>
            public static readonly object RepositoryGitDirectory;
        }

    }
}

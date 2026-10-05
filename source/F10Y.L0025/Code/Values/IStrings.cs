using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0025
{
    [ValuesMarker]
    public partial interface IStrings :
        L0000.IStrings
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IStrings _L0000 => L0000.Strings.Instance;

#pragma warning restore IDE1006 // Naming Styles


#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>dirty</value></para>
        /// </summary>
        string dirty => "dirty";

        /// <summary>
        /// <para><value>stashes exist</value></para>
        /// </summary>
        string stashes_Exist => "stashes exist";

        /// <summary>
        /// <para><value>unpushed commits exist</value></para>
        /// </summary>
        string unpushedCommits_Exist => "unpushed commits exist";

        /// <summary>
        /// <para><value>untracked - and not ignored - files exist</value></para>
        /// </summary>
        string untrackedAndNotIgnoredFiles_Exist => "untracked - and not ignored - files exist";

#pragma warning restore IDE1006 // Naming Styles
    }
}

using System;

using F10Y.T0002;
using LibGit2Sharp;


namespace F10Y.L0025
{
    [FunctionsMarker]
    public partial interface IBranchOperator
    {
        bool Is_AheadOfRemote(Branch branch)
            => !branch.IsTracking || branch.TrackingDetails.AheadBy > 0;
    }
}

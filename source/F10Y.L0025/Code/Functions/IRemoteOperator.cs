using System;

using LibGit2Sharp;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0025
{
    [FunctionsMarker]
    public partial interface IRemoteOperator
    {
        [InstanceIdentity("BB977E2B-9745-4010-8E86-B02D19E7B588")]
        public string Get_Url(Remote remote)
        {
            var url = remote.Url;
            return url;
        }
    }
}

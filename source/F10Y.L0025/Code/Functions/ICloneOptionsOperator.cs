using System;

using LibGit2Sharp;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0025
{
    [FunctionsMarker]
    public partial interface ICloneOptionsOperator
    {
        [InstanceIdentity("D30392D3-5EE6-47D7-B4D7-217ABAF2CCF3")]
        public CloneOptions Get_CloneOptions(
            string username,
            string password)
        {
            var cloneOptions = new CloneOptions();

            Instances.FetchOptionsOperator.Set_CredentialsProvider(
                cloneOptions.FetchOptions,
                username,
                password);

            return cloneOptions;
        }
    }
}

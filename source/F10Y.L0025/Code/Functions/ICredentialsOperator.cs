using System;

using LibGit2Sharp;
using LibGit2Sharp.Handlers;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0025
{
    [FunctionsMarker]
    public partial interface ICredentialsOperator
    {
        [InstanceIdentity("5B84B107-BCD9-4CC6-B2AE-3FB99607FC1B")]
        public CredentialsHandler Get_CredentialsHandler(
            string username,
            string password)
        {
            var output = new CredentialsHandler(
                (url, usernameFromUrl, types) =>
                new UsernamePasswordCredentials()
                {
                    Username = username,
                    Password = password,
                }
            );

            return output;
        }
    }
}

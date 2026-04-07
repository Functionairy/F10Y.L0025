using System;

using LibGit2Sharp;

using F10Y.T0002;


namespace F10Y.L0025
{
    [FunctionsMarker]
    public partial interface IPushOptionsOperator
    {
        PushOptions Get_PushOptions(
            string username,
            string password)
        {
            var pushOptions = new PushOptions
            {
                CredentialsProvider = Instances.CredentialsOperator.Get_CredentialsHandler(
                    username,
                    password)
            };

            return pushOptions;
        }
    }
}

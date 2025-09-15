using System;

using LibGit2Sharp;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0025
{
    [FunctionsMarker]
    public partial interface IFetchOptionsOperator
    {
        [InstanceIdentity("D0A50A2A-EFB3-4F7C-BE40-C293BD18F563")]
        public FetchOptions Get_FetchOptions(
            string username,
            string password)
        {
            var fetchOptions = new FetchOptions();

            this.Set_CredentialsProvider(
                fetchOptions,
                username,
                password);

            return fetchOptions;
        }

        [InstanceIdentity("0CB6E391-1D62-4FB1-823D-D5F8D8AAD254")]
        public void Set_CredentialsProvider(
            FetchOptions fetchOptions,
            string username,
            string password)
        {
            fetchOptions.CredentialsProvider = Instances.CredentialsOperator.Get_CredentialsHandler(
                username,
                password);
        }
    }
}

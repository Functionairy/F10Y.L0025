using System;


namespace F10Y.L0025
{
    public class CredentialsOperator : ICredentialsOperator
    {
        #region Infrastructure

        public static ICredentialsOperator Instance { get; } = new CredentialsOperator();


        private CredentialsOperator()
        {
        }

        #endregion
    }
}

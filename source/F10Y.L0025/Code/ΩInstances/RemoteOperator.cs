using System;


namespace F10Y.L0025
{
    public class RemoteOperator : IRemoteOperator
    {
        #region Infrastructure

        public static IRemoteOperator Instance { get; } = new RemoteOperator();


        private RemoteOperator()
        {
        }

        #endregion
    }
}

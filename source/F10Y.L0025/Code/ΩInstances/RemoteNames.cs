using System;


namespace F10Y.L0025
{
    public class RemoteNames : IRemoteNames
    {
        #region Infrastructure

        public static IRemoteNames Instance { get; } = new RemoteNames();


        private RemoteNames()
        {
        }

        #endregion
    }
}

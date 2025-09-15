using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0025
{
    /// <summary>
    /// Names of common remote Git repositories.
    /// </summary>
    [ValuesMarker]
    public partial interface IRemoteNames
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>master</value></para>
        /// </summary>
        public string master => "master";

        /// <summary>
        /// <para><value>origin</value></para>
        /// </summary>
        [InstanceIdentity("754DF21D-ABEA-4A76-955A-10F9612FBDF2")]
        public string origin => "origin";

#pragma warning restore IDE1006 // Naming Styles
    }
}

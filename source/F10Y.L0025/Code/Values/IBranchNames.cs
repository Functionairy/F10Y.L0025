using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0025
{
    [ValuesMarker]
    public partial interface IBranchNames
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>main</value></para>
        /// New politically correct name for master branch.
        /// </summary>
        [InstanceIdentity("1C1467CE-2A2B-4FEB-AC50-4BE68718CD3F")]
        public string main => "main";

        /// <summary>
        /// <para><value>master</value></para>
        /// </summary>
        [InstanceIdentity("9F698146-0221-4759-A5F1-55069A37D017")]
        public string master => "master";

#pragma warning restore IDE1006 // Naming Styles
    }
}

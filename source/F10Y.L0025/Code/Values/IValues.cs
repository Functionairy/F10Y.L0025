using System;

using LibGit2Sharp;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0025
{
    [ValuesMarker]
    public partial interface IValues
    {
        /// <summary>
        /// Null
        /// </summary>
        [InstanceIdentity("3F61E545-A036-4360-9C63-B3E93ECA9C47")]
        public Branch Branch_NotFound => null;

        /// <summary>
        /// <para><value>&lt;null&gt;</value></para>
        /// The value returned by <see cref="Repository.Discover(string)"/> if no Git repository is found for the given path.
        /// </summary>
        public const string Repository_NotFound_DirectoryPath_Constant = null;

        /// <inheritdoc cref="Repository_NotFound_DirectoryPath_Constant"/>
        public string Repository_NotFound_DirectoryPath => IValues.Repository_NotFound_DirectoryPath_Constant;
    }
}

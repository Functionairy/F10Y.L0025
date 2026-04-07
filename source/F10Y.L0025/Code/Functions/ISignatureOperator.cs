using System;

using LibGit2Sharp;

using F10Y.T0002;


namespace F10Y.L0025
{
    [FunctionsMarker]
    public partial interface ISignatureOperator
    {
        Signature Get_Signature(
            string name,
            string emailAddress)
        {
            // Use local time (since it will be implicitly converted to the offeet).
            var when = Instances.NowOperator.Get_Now_Local();

            var output = new Signature(
                name,
                emailAddress,
                when);

            return output;
        }
    }
}

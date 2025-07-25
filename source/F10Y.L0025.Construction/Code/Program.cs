using System;
using System.Threading.Tasks;


namespace F10Y.L0025.Construction
{
    class Program
    {
        static async Task Main()
        {
            //await Program.Demonstrations_();
            await Program.Demonstrations_Git();
        }


        #region Demonstrations

        static Task Demonstrations_()
        {
            throw new NotImplementedException();
        }

        static async Task Demonstrations_Git()
        {
            await Instances.GitDemonstrations.List_FileChanges_ByCommit_ForRepository();
        }

        #endregion
    }
}
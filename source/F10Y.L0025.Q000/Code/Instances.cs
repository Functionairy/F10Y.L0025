using System;


namespace F10Y.L0025.Q000
{
    public static class Instances
    {
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static L0000.IFileOperator FileOperator => L0000.FileOperator.Instance;
        public static L0004.L000.IFilePaths FilePaths => L0004.L000.FilePaths.Instance;
        public static L0019.INotepadPlusPlusOperator NotepadPlusPlusOperator => L0019.NotepadPlusPlusOperator.Instance;
        public static IRepositoryOperator RepositoryOperator => L0025.RepositoryOperator.Instance;
    }
}
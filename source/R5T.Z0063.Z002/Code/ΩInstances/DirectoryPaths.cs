using System;


namespace R5T.Z0063.Z002
{
    public class DirectoryPaths : IDirectoryPaths
    {
        #region Infrastructure

        public static IDirectoryPaths Instance { get; } = new DirectoryPaths();


        private DirectoryPaths()
        {
        }

        #endregion
    }
}

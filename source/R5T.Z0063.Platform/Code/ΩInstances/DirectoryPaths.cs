using System;


namespace R5T.Z0063.Platform
{
    [Obsolete("See R5T.Z0063.Z002.DirectoryPaths")]
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

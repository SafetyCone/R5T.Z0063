using System;


namespace R5T.Z0063.Platform
{
    [Obsolete("See R5T.Z0063.Z002.FilePaths")]
    public class FilePaths : IFilePaths
    {
        #region Infrastructure

        public static IFilePaths Instance { get; } = new FilePaths();


        private FilePaths()
        {
        }

        #endregion
    }
}


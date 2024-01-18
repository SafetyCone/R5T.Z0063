using System;

using R5T.T0131;
using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.Z0063
{
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private static Platform.IDirectoryPaths _Platform => Platform.DirectoryPaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Platform.IDirectoryPaths.Temp"/>
        public IDirectoryPath Temp => _Platform.Temp.ToDirectoryPath();
    }
}

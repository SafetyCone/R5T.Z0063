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
        private static Z002.IDirectoryPaths _Strings => Z002.DirectoryPaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z002.IDirectoryPaths.Temp"/>
        public IDirectoryPath Temp => _Strings.Temp.ToDirectoryPath();
    }
}

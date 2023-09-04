using System;

using R5T.T0131;
using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.Z0063
{
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
        private static Platform.IDirectoryPaths Platform => Z0063.Platform.DirectoryPaths.Instance;


        public IDirectoryPath Temp => Platform.Temp.ToDirectoryPath();
    }
}

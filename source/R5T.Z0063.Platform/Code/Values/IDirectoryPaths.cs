using System;

using R5T.T0131;


namespace R5T.Z0063.Platform
{
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
        public string Temp => @"C:\Temp\";
    }
}

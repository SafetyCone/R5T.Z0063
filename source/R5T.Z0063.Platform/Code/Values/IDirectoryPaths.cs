using System;

using R5T.T0131;


namespace R5T.Z0063.Platform
{
    [ValuesMarker]
    [Obsolete("See R5T.Z0063.Z002.IDirectoryPaths")]
    public partial interface IDirectoryPaths : IValuesMarker
    {
        /// <summary>
        /// <para><value>C:\Temp\</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0063.Z002.IDirectoryPaths.Temp")]
        public string Temp => @"C:\Temp\";
    }
}

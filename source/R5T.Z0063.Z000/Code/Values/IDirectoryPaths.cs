using System;

using R5T.T0131;


namespace R5T.Z0063.Z000
{
    /// <summary>
    /// Absolutely-named, fundamental, stringly-typed output directory paths
    /// (of all, any, or undetermined opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
        /// <summary>
        /// <para><value>C:\Temp\</value></para>
        /// </summary>
        public string C_Temp => @"C:\Temp\";
    }
}

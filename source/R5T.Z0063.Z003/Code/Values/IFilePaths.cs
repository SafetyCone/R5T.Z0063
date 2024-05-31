using System;

using R5T.T0131;
using R5T.T0252;


namespace R5T.Z0063.Z003
{
    /// <summary>
    /// Conceptually named, derived, leaf strong-typed output file paths
    /// (of all, any, or undetermined opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private Z001.IFilePaths _Raw => Z001.FilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z001.IFilePaths.C_Temp_Output_txt"/>
        public IFilePath Output_Text_FilePath => _Raw.C_Temp_Output_txt;
    }
}

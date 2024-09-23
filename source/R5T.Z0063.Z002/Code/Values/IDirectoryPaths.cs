using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0063.Z002
{
    /// <summary>
    /// Conceptually-named, derived, stringly-typed output directory paths
    /// (of all, any, or undetermined opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z000.IDirectoryPaths _Raw => Z000.DirectoryPaths.Instance;

#pragma warning restore IDE1006 // Naming Styles

        /// <summary>
        /// <para><inheritdoc cref="Z000.IDirectoryPaths.C_Temp" path="descendant::value"/></para>
        /// </summary>
        public string Temp => _Raw.C_Temp;
    }
}

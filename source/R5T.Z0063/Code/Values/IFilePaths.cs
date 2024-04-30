using System;

using R5T.T0131;
using R5T.T0181;
using R5T.T0181.Extensions;


namespace R5T.Z0063
{
    /// <summary>
    /// Useful output file paths.
    /// </summary>
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Platform.IFilePaths _Platform => Platform.FilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public ITextFilePath HumanOutputTextFilePath => _Platform.HumanOutputTextFilePath.ToTextFilePath();
        public ILogFilePath LogFilePath => _Platform.LogFilePath.ToLogFilePath();
        public IDataFilePath OutputDataFilePath => _Platform.OutputDataFilePath.ToDataFilePath();

        /// <inheritdoc cref="Platform.IFilePaths.OutputErrorsTextFilePath"/>
        public ITextFilePath OutputErrorsTextFilePath => _Platform.OutputErrorsTextFilePath.ToTextFilePath();
        public IHtmlFilePath OutputHtmlFilePath => _Platform.OutputHtmlFilePath.ToHtmlFilePath();

        /// <inheritdoc cref="Platform.IFilePaths.OutputJsonFilePath"/>
        public IJsonFilePath OutputJsonFilePath => _Platform.OutputJsonFilePath.ToJsonFilePath();
        public ITextFilePath OutputTextFilePath => _Platform.OutputTextFilePath.ToTextFilePath();
        public ITextFilePath OutputTextFilePath_Secondary => _Platform.OutputTextFilePath_Secondary.ToTextFilePath();
        public ITextFilePath OutputTextFilePath_Tertiary => _Platform.OutputTextFilePath_Tertiary.ToTextFilePath();
        public IXmlFilePath OutputXmlFilePath => _Platform.OutputXmlFilePath.ToXmlFilePath();
        public IJsonFilePath RawOutputJsonFilePath => _Platform.RawOutputJsonFilePath.ToJsonFilePath();
        public IJsonFilePath ResultOutputJsonFilePath => _Platform.ResultOutputJsonFilePath.ToJsonFilePath();
    }
}

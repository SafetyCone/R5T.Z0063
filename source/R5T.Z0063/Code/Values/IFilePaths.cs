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
        private static Platform.IFilePaths Platform => Z0063.Platform.FilePaths.Instance;


        public ITextFilePath HumanOutputTextFilePath => Platform.HumanOutputTextFilePath.ToTextFilePath();
        public ILogFilePath LogFilePath => Platform.LogFilePath.ToLogFilePath();
        public IDataFilePath OutputDataFilePath => Platform.OutputDataFilePath.ToDataFilePath();
        public ITextFilePath OutputErrorsTextFilePath => Platform.OutputErrorsTextFilePath.ToTextFilePath();
        public IHtmlFilePath OutputHtmlFilePath => Platform.OutputHtmlFilePath.ToHtmlFilePath();
        public IJsonFilePath OutputJsonFilePath => Platform.OutputJsonFilePath.ToJsonFilePath();
        public ITextFilePath OutputTextFilePath => Platform.OutputTextFilePath.ToTextFilePath();
        public ITextFilePath OutputTextFilePath_Secondary => Platform.OutputTextFilePath_Secondary.ToTextFilePath();
        public ITextFilePath OutputTextFilePath_Tertiary => Platform.OutputTextFilePath_Tertiary.ToTextFilePath();
        public IXmlFilePath OutputXmlFilePath => Platform.OutputXmlFilePath.ToXmlFilePath();
        public IJsonFilePath RawOutputJsonFilePath => Platform.RawOutputJsonFilePath.ToJsonFilePath();
        public IJsonFilePath ResultOutputJsonFilePath => Platform.ResultOutputJsonFilePath.ToJsonFilePath();
    }
}

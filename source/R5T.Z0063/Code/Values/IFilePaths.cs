using System;

using R5T.T0131;
using R5T.T0143;
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

        [Ignore]
        public Z002.IFilePaths _Strings => Z002.FilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles

        /// <inheritdoc cref="Z002.IFilePaths.Human_Output_Text_FilePath"/>
        public ITextFilePath HumanOutputTextFilePath => _Strings.Human_Output_Text_FilePath.ToTextFilePath();

        /// <inheritdoc cref="Z002.IFilePaths.Log_FilePath"/>
        public ILogFilePath LogFilePath => _Strings.Log_FilePath.ToLogFilePath();

        /// <inheritdoc cref="Z002.IFilePaths.Output_Data_FilePath"/>
        public IDataFilePath OutputDataFilePath => _Strings.Output_Data_FilePath.ToDataFilePath();

        /// <inheritdoc cref="Z002.IFilePaths.Output_Errors_Text_FilePath"/>
        public ITextFilePath OutputErrorsTextFilePath => _Strings.Output_Errors_Text_FilePath.ToTextFilePath();

        /// <inheritdoc cref="Z002.IFilePaths.Output_Html_FilePath"/>
        public IHtmlFilePath OutputHtmlFilePath => _Strings.Output_Html_FilePath.ToHtmlFilePath();

        /// <inheritdoc cref="Z002.IFilePaths.Output_Json_FilePath"/>
        public IJsonFilePath OutputJsonFilePath => _Strings.Output_Json_FilePath.ToJsonFilePath();

        /// <inheritdoc cref="Z002.IFilePaths.Output_Text_FilePath"/>
        public ITextFilePath OutputTextFilePath => _Strings.Output_Text_FilePath.ToTextFilePath();

        /// <inheritdoc cref="Z002.IFilePaths.Output_Text_FilePath_Secondary"/>
        public ITextFilePath OutputTextFilePath_Secondary => _Strings.Output_Text_FilePath_Secondary.ToTextFilePath();

        /// <inheritdoc cref="Z002.IFilePaths.Output_Text_FilePath_Tertiary"/>
        public ITextFilePath OutputTextFilePath_Tertiary => _Strings.Output_Text_FilePath_Tertiary.ToTextFilePath();

        /// <inheritdoc cref="Z002.IFilePaths.Output_Xml_FilePath"/>
        public IXmlFilePath OutputXmlFilePath => _Strings.Output_Xml_FilePath.ToXmlFilePath();

        /// <inheritdoc cref="Z002.IFilePaths.Output_Raw_Json_FilePath"/>
        public IJsonFilePath RawOutputJsonFilePath => _Strings.Output_Raw_Json_FilePath.ToJsonFilePath();

        /// <inheritdoc cref="Z002.IFilePaths.Result_Output_Json_FilePath"/>
        public IJsonFilePath ResultOutputJsonFilePath => _Strings.Result_Output_Json_FilePath.ToJsonFilePath();
    }
}

using System;

using R5T.T0131;


namespace R5T.Z0063.Platform
{
    [ValuesMarker]
    [Obsolete("See R5T.Z0063.Z002.IFilePaths")]
    public partial interface IFilePaths : IValuesMarker
    {
        //private static Raw.IFilePaths Raw => Platform.Raw.FilePaths.Instance;

        [Obsolete("See R5T.Z0063.Z002.IFilePaths.Human_Output_Text_FilePath")]
        public string HumanOutputTextFilePath => @"C:\Temp\Human Output.txt";

        [Obsolete("See R5T.Z0063.Z002.IFilePaths.Log_FilePath")]
        public string LogFilePath => @"C:\Temp\log.txt";

        [Obsolete("See R5T.Z0063.Z002.IFilePaths.Output_Data_FilePath")]
        public string OutputDataFilePath => @"C:\Temp\Output.dat";

        /// <summary>
        /// <para><value>C:\Temp\Errors.txt</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0063.Z002.IFilePaths.Output_Errors_Text_FilePath")]
        public string OutputErrorsTextFilePath => @"C:\Temp\Errors.txt";

        [Obsolete("See R5T.Z0063.Z002.IFilePaths.Output_Html_FilePath")]
        public string OutputHtmlFilePath => @"C:\Temp\Output.html";

        /// <summary>
        /// <para><value>C:\Temp\Output.json</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0063.Z002.IFilePaths.Output_Json_FilePath")]
        public string OutputJsonFilePath => @"C:\Temp\Output.json";

        /// <summary>
        /// <para><value>C:\Temp\Output.txt</value></para>
        /// </summary>
        [Obsolete("See R5T.Z0063.Z002.IFilePaths.")]
        public string OutputTextFilePath => @"C:\Temp\Output.txt";

        [Obsolete("See R5T.Z0063.Z002.IFilePaths.Output_Text_FilePath_Secondary")]
        public string OutputTextFilePath_Secondary => @"C:\Temp\Output2.txt";

        [Obsolete("See R5T.Z0063.Z002.IFilePaths.Output_Text_FilePath_Tertiary")]
        public string OutputTextFilePath_Tertiary => @"C:\Temp\Output3.txt";

        [Obsolete("See R5T.Z0063.Z002.IFilePaths.Output_Xml_FilePath")]
        public string OutputXmlFilePath => @"C:\Temp\Output.xml";

        [Obsolete("See R5T.Z0063.Z002.IFilePaths.Output_Raw_Json_FilePath")]
        public string Output_Raw_Json_FilePath => @"C:\Temp\Output-Raw.json";

        [Obsolete("See R5T.Z0063.Z002.IFilePaths.Result_Output_Json_FilePath")]
        public string ResultOutputJsonFilePath => @"C:\Temp\Result.json";
    }
}

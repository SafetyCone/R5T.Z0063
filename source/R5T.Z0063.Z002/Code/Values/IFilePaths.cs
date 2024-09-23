using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0063.Z002
{
    /// <summary>
    /// Contextually-named, derived, stringly-typed output file paths
    /// (of all, any, or undetermined opinion).
    /// </summary>
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z000.IFilePaths _Raw => Z000.FilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// The human output text file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Human_Output_txt" path="descendant::value"/></para>
        /// </summary>
        public string Human_Output_Text_FilePath => _Raw.C_Temp_Human_Output_txt;

        /// <summary>
        /// The log text file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_log_txt" path="descendant::value"/></para>
        /// </summary>
        public string Log_FilePath => _Raw.C_Temp_log_txt;

        /// <summary>
        /// The output data file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Output_dat" path="descendant::value"/></para>
        /// Placed in the temp directory.
        /// </summary>
        public string Output_Data_FilePath => _Raw.C_Temp_Output_dat;

        /// <summary>
        /// The output errors file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Errors_txt" path="descendant::value"/></para>
        /// </summary>
        public string Output_Errors_Text_FilePath => _Raw.C_Temp_Errors_txt;

        /// <summary>
        /// The output Excel file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Errors_txt" path="descendant::value"/></para>
        /// </summary>
        public string Output_Excel_FilePath => _Raw.C_Temp_Output_xlsx;

        /// <summary>
        /// The output Word file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Output_docx" path="descendant::value"/></para>
        /// </summary>
        public string Output_Word_FilePath => _Raw.C_Temp_Output_docx;

        /// <summary>
        /// The output HTML file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Output_html" path="descendant::value"/></para>
        /// </summary>
        public string Output_Html_FilePath => _Raw.C_Temp_Output_html;

        /// <summary>
        /// The output JSON file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Output_json" path="descendant::value"/></para>
        /// </summary>
        public string Output_Json_FilePath => _Raw.C_Temp_Output_json;

        /// <summary>
        /// The output raw JSON file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Output_Raw_json" path="descendant::value"/></para>
        /// </summary>
        public string Output_Raw_Json_FilePath => _Raw.C_Temp_Output_Raw_json;

        /// <summary>
        /// The output text file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Output_txt" path="descendant::value"/></para>
        /// Placed in the temp directory.
        /// </summary>
        public string Output_Text_FilePath => _Raw.C_Temp_Output_txt;

        /// <summary>
        /// The secondary output text file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Output2_txt" path="descendant::value"/></para>
        /// </summary>
        public string Output_Text_FilePath_Secondary => _Raw.C_Temp_Output2_txt;

        /// <summary>
        /// The tertiary output text file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Output3_txt" path="descendant::value"/></para>
        /// </summary>
        public string Output_Text_FilePath_Tertiary => _Raw.C_Temp_Output3_txt;

        /// <summary>
        /// The output XML file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Output_html" path="descendant::value"/></para>
        /// </summary>
        public string Output_Xml_FilePath => _Raw.C_Temp_Output_xml;

        /// <summary>
        /// The result output JSON file path.
        /// <para><inheritdoc cref="Z000.IFilePaths.C_Temp_Result_json" path="descendant::value"/></para>
        /// </summary>
        public string Result_Output_Json_FilePath => _Raw.C_Temp_Result_json;
    }
}

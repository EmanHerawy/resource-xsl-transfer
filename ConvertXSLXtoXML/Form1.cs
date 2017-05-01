using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ConvertXSLXtoXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // private string currentFileName;

        Dictionary<string, string> resourceKeys = new Dictionary<string, string>();
        Dictionary<string, string> dutchNewLangTranslation = new Dictionary<string, string>();
        private void btnStart_Click(object sender, EventArgs e)
        {

            #region TotalCode
            //System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            //Excel.Application xlApp = new Excel.Application();
            //Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Ahmed\Desktop\1.Mijn vacatures.xls");
            //Excel._Worksheet xlworkSheet = xlWorkbook.Sheets[1];
            //Excel.Range xlRange = xlworkSheet.UsedRange;


            //int rowCount = xlRange.Rows.Count;
            //int colCount = xlRange.Columns.Count;
            //var dutchNewLangTranslation = new Dictionary<string, string>();
            //for (int i = 2; i <= rowCount; i++) {
            //    var dutchTranslation = string.Empty;
            //    var newLangTranslation = string.Empty;
            //    for (int j = 2; j <= colCount; j++) {
            //        var ss = xlRange.Cells[i, j];
            //        if (j == 2) {
            //            dutchTranslation = xlRange.Cells[i, j].Value2;
            //        }
            //        if (j == 3) {
            //            newLangTranslation = xlRange.Cells[i, j].Value2;
            //        }
            //    }
            //    if (!dutchNewLangTranslation.ContainsKey(dutchTranslation))
            //        dutchNewLangTranslation.Add(dutchTranslation, newLangTranslation);
            //}
            //string path = Directory.GetCurrentDirectory();

            //ResXResourceReader s = new ResXResourceReader(string.Format(@"C:\Users\Ahmed\Desktop\Labels.resx"));
            //s.UseResXDataNodes = true;
            //IDictionaryEnumerator enumerator = s.GetEnumerator();
            //Assembly currentAssembly = Assembly.GetExecutingAssembly();
            //while (enumerator.MoveNext())
            //{
            //    //Fill the combobox with all key/value pairs
            //    if (!resourceKeys.ContainsKey((string) enumerator.Key))
            //    {
            //        var node = (ResXDataNode) enumerator.Value;
            //        var valueObj = node.GetValue(new AssemblyName[] {currentAssembly.GetName()});
            //        var valueText = valueObj.ToString();
            //        resourceKeys.Add((string) enumerator.Key, valueText);
            //    }
            //}

            //var newLanguageResources = new Dictionary<string, string>();
            //// value in resourcesKeys is key in dutchEnglishtranslations
            //foreach (var item in resourceKeys) {
            //    if (dutchNewLangTranslation.ContainsKey(item.Value))
            //    {

            //        newLanguageResources.Add(item.Key , dutchNewLangTranslation[item.Value]);
            //    }
            //}
            //ResXResourceWriter sWriter = new ResXResourceWriter(@"C:\Users\Ahmed\Desktop\English.resx");
            //foreach (var item in newLanguageResources)
            //{
            //    sWriter.AddResource(item.Key , item.Value);
            //}
            //sWriter.Generate();
            //sWriter.Close();
            #endregion
            string start = "";
            string end = "";
            if (!string.IsNullOrWhiteSpace(txtRangeStart.Text.Trim()) &&
                !string.IsNullOrWhiteSpace(txtRangeEnd.Text.Trim()))
            {
                start = ConvertAlphaToNumeric(txtRangeStart.Text.Trim());
                end = ConvertAlphaToNumeric(txtRangeEnd.Text.Trim());

            }

            if (!string.IsNullOrWhiteSpace(start) && !string.IsNullOrWhiteSpace(end))
            {
                ExtractTranslationsFromWorkSheet(txtbxExcelfileName.Text, Convert.ToInt32(start.Split('*')[0]), Convert.ToInt32(start.Split('*')[1]), Convert.ToInt32(end.Split('*')[0]), Convert.ToInt32(end.Split('*')[1]));
                ExtractKeysFromResourcesFiles(txtbxResxFilePath.Text);
                string fullNewFileName = string.Format("{0}/{1}", folderBrowserDialog1.SelectedPath,
                    txtbxNewResxFileName.Text);
                if (GenerateNewResourcesFile(fullNewFileName))
                {
                    MessageBox.Show("Generating resource file has been done successfully ");
                    txtbxExcelfileName.Text = null;
                    txtRangeEnd.Text = null;
                    txtRangeStart.Text = null;
                    txtbxNewResxFileName.Text = null;
                    txtbxSaveLoc.Text = null;
                    txtbxResxFilePath.Text = null;
                }
            }
        }

        public void ExtractTranslationsFromWorkSheet(string excelFilePath, int startRow, int startColumn, int endRow, int endColumn)
        {
            System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(excelFilePath);
            Excel._Worksheet xlworkSheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlworkSheet.UsedRange;


            int rowCount = endRow - startRow + 1;
            int colCount = endColumn - startColumn + 1;

            for (int i = startRow; i <= rowCount; i++)
            {
                var dutchTranslation = string.Empty;
                var newLangTranslation = string.Empty;
                for (int j = startColumn; j <= endColumn; j++)
                {
                    var ss = xlRange.Cells[i, j];
                    if (j == startColumn)
                    {
                        dutchTranslation = xlRange.Cells[i, j].Value2;
                    }
                    if (j == endColumn)
                    {
                        newLangTranslation = xlRange.Cells[i, j].Value2;
                    }
                }
                if (!dutchNewLangTranslation.ContainsKey(dutchTranslation))
                    dutchNewLangTranslation.Add(dutchTranslation, newLangTranslation);
            }
        }

        public void ExtractKeysFromResourcesFiles(string resourcesFilePath)
        {
            ResXResourceReader s = new ResXResourceReader(resourcesFilePath);
            s.UseResXDataNodes = true;
            IDictionaryEnumerator enumerator = s.GetEnumerator();

            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            while (enumerator.MoveNext())
            {
                //Fill the combobox with all key/value pairs
                if (!resourceKeys.ContainsKey((string)enumerator.Key))
                {
                    var node = (ResXDataNode)enumerator.Value;
                    var valueObj = node.GetValue(new AssemblyName[] { currentAssembly.GetName() });
                    var valueText = valueObj.ToString();
                    resourceKeys.Add((string)enumerator.Key, valueText);
                }
            }
        }

        public bool GenerateNewResourcesFile(string newFileName)
        {
            var newLanguageResources = new Dictionary<string, string>();
            // value in resourcesKeys is key in dutchEnglishtranslations
            foreach (var item in resourceKeys)
            {
                if (dutchNewLangTranslation.ContainsKey(item.Value))
                {
                    newLanguageResources.Add(item.Key, dutchNewLangTranslation[item.Value]);
                }
            }
            ResXResourceWriter sWriter = new ResXResourceWriter(newFileName);
            foreach (var item in newLanguageResources)
            {
                sWriter.AddResource(item.Key, item.Value);
            }
            sWriter.Generate();
            sWriter.Close();
            return true;
        }

        private void btnExcel1_Click(object sender, EventArgs e)
        {







            //openFileDialog1.AddExtension = true;
            //// ***** strange way to handel opendialogebox 
            //if (openFileDialog1.CheckFileExists)
            //    currentFileName = openFileDialog1.FileName;
            var thisControl = (Button)sender;
            if (thisControl.Name.Equals("btnExcel1"))
            {

                openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtbxExcelfileName.Text = openFileDialog1.FileName;

                }

            }
            else if (thisControl.Name.Equals("btnResx"))
            {
                openFileDialog1.Filter = "Resource Files|*.resx;";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtbxResxFilePath.Text = openFileDialog1.FileName;
                }


            }
        }

        private void btnSaveLoc_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            folderBrowserDialog1.ShowNewFolderButton = true;
            txtbxSaveLoc.Text = folderBrowserDialog1.SelectedPath;
        }

        private string ConvertAlphaToNumeric(string range)
        {
            string cellName = range.Substring(0, 1).ToUpper();
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (alpha.IndexOf(cellName) >= 0)
            {
                return string.Format("{1}*{0}", alpha.IndexOf(cellName) + 1, range.Substring(1));
            }
            return null;
        }

        private void btnGenerateScripts_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}


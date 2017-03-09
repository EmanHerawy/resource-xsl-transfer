using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertXSLXtoXML {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;
        Dictionary<string,string> txtAndLabel = new Dictionary<string, string>();
        List<Control> controlsList = new List<Control>();
        private string columnsString;
        private string totalScripts;
 
        private int NumberOfSecColumn = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var script  = new StringBuilder();
            if (string.IsNullOrWhiteSpace(totalScripts))
               script.AppendLine(script.AppendFormat("INSERT INTO {0} ({1})VALUES({2})", txtbxTableName.Text, columnsString,
                    GetNewValues()).ToString());
            else
            {
                
                script.AppendLine("------------------------------------------------------");
                script.AppendLine(script.AppendFormat("INSERT INTO {0} ({1})VALUES({2})", txtbxTableName.Text, columnsString,
                        GetNewValues()).ToString());
            }

            totalScripts += script.ToString();
            MessageBox.Show(totalScripts);
        }

        private void btnAddCol_Click(object sender, EventArgs e) {
            //AddColumns();
            var control = this.Controls.Find(string.Format("newTextBx{0}Val", "ss"), true);
            //if (control != null && control.FirstOrDefault().)
            //{
                
            //}
            GetActualData();
        }

        private void AddColumns(string name)
        {
            Label newLabel = new Label();
            newLabel.Name = string.Format("newLabel{0}",name);
            newLabel.Location = new Point() { X = lblPrimaryColumn.Location.X, Y = lblPrimaryColumn.Location.Y + (50 * (NumberOfSecColumn + 1)) };
            newLabel.Size = lblPrimaryColumn.Size;
            newLabel.Text = name;


            TextBox newTextBox = new TextBox();
            newTextBox.Name = string.Format("newTxtBx{0}Val",name);
            newTextBox.Location = new Point() { X = txtbxOriginalTrans.Location.X, Y = txtbxOriginalTrans.Location.Y + (50 * (NumberOfSecColumn + 1)) };
            newTextBox.Size = txtbxOriginalTrans.Size;
            newTextBox.Text = string.Empty;
            newTextBox.AccessibleName = string.Format("newTxtBx{0}Val", name);
            newTextBox.IsAccessible = true;
            controlsList.Add(newLabel);
            controlsList.Add(newTextBox);
           
            
            this.Controls.Add(newLabel);
            this.Controls.Add(newTextBox);
            txtAndLabel.Add(newLabel.Text , newTextBox.Text);
            NumberOfSecColumn++;
        }

        private void btnGetColumn_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(txtbxTableName.Text))
            {
                connection =
                    new SqlConnection(
                        @"data source=TOSHIBA\SQLWORK;Initial Catalog=volunteer-Dev;Integrated Security=true");
                var commandTxt = string.Format(@"SELECT COLUMN_NAME From INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{0}'", txtbxTableName.Text);
                command = new SqlCommand(commandTxt, connection);
                var dataTable = new DataTable();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                int skipId = 1;
                if (dataTable.Rows != null && dataTable.Rows.Count > 0) {
                    foreach (DataRow datarow in dataTable.Rows) {
                        if (skipId == 1) {
                            skipId++;
                            continue;
                        }
                        var columnName = datarow.ItemArray.FirstOrDefault().ToString();
                        AddColumns(columnName);
                    }
                }
            }
        }

        private void GetActualData()
        {
            if (!string.IsNullOrWhiteSpace(txtbxTableName.Text) && !string.IsNullOrWhiteSpace(txtbxOriginalTrans.Text))
            {
                connection =
                    new SqlConnection(
                        @"data source=TOSHIBA\SQLWORK;Initial Catalog=volunteer-Dev;Integrated Security=true");
                var commandTxt = string.Format(@"SELECT * From {0} where Translation = '{1}' ", txtbxTableName.Text,txtbxOriginalTrans.Text);
                command = new SqlCommand(commandTxt, connection);
                var dataTable = new DataTable();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                int skipId = 0;
                Control control = null;
                if (dataTable.Rows != null && dataTable.Rows.Count > 0) {
                    foreach (DataColumn col in dataTable.Columns)
                    {
                        if (skipId == 0) {
                            skipId++;
                            continue;
                        }
                        var column = col.ColumnName;
                        control = GetTextBox(column);
                        columnsString = string.Format("{0}{1}{2}", columnsString, !string.IsNullOrWhiteSpace(columnsString) ? "," : string.Empty, column);
                        foreach (DataRow datarow in dataTable.Rows) {
                            control.Text = datarow.ItemArray[skipId].ToString();
                        }
                        skipId++;
                    }
                    
                }
            }
        }

        private TextBox GetTextBox(string name) {
            var Name = string.Format("newTxtBx{0}Val", name);
            foreach (Control c in controlsList)
                if (c.Name == Name)
                    return (TextBox)c;

            return null;
        }

        private void btnGenerateScripts_Click(object sender, EventArgs e)
        {

            var insertInto = string.Format("INSERT INTO {0} ({1})VALUES({2})", txtbxTableName.Text, columnsString,
                GetNewValues());
            MessageBox.Show(insertInto);

        }

        private string GetNewValues() {
            var newValueString = string.Empty;
            foreach (var control in controlsList) {
                if (control.Name.Contains("newTxtBx"))
                {
                    int succeed ;
                    var value = int.TryParse(control.Text, out succeed);

                    newValueString = string.Format("{0} {1} {2}", newValueString,
                        !string.IsNullOrWhiteSpace(newValueString) ? "," : string.Empty, succeed == 0? string.Format("'{0}'", control.Text) : control.Text);
                }
            }
            return newValueString;
        }
    }
}

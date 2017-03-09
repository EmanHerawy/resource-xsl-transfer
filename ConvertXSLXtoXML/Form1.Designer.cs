namespace ConvertXSLXtoXML {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtbxExcelfileName = new System.Windows.Forms.TextBox();
            this.txtbxResxFilePath = new System.Windows.Forms.TextBox();
            this.txtbxNewResxFileName = new System.Windows.Forms.TextBox();
            this.txtbxSaveLoc = new System.Windows.Forms.TextBox();
            this.btnExcel1 = new System.Windows.Forms.Button();
            this.btnResx = new System.Windows.Forms.Button();
            this.btnSaveLoc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRangeStart = new System.Windows.Forms.TextBox();
            this.txtRangeEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerateScripts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(216, 248);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(152, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Convert & Generate";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Excel File Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resources File Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Resources File Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Save Location :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtbxExcelfileName
            // 
            this.txtbxExcelfileName.Location = new System.Drawing.Point(193, 39);
            this.txtbxExcelfileName.Name = "txtbxExcelfileName";
            this.txtbxExcelfileName.Size = new System.Drawing.Size(322, 20);
            this.txtbxExcelfileName.TabIndex = 5;
            // 
            // txtbxResxFilePath
            // 
            this.txtbxResxFilePath.Location = new System.Drawing.Point(193, 117);
            this.txtbxResxFilePath.Name = "txtbxResxFilePath";
            this.txtbxResxFilePath.Size = new System.Drawing.Size(322, 20);
            this.txtbxResxFilePath.TabIndex = 6;
            // 
            // txtbxNewResxFileName
            // 
            this.txtbxNewResxFileName.Location = new System.Drawing.Point(193, 162);
            this.txtbxNewResxFileName.Name = "txtbxNewResxFileName";
            this.txtbxNewResxFileName.Size = new System.Drawing.Size(322, 20);
            this.txtbxNewResxFileName.TabIndex = 7;
            // 
            // txtbxSaveLoc
            // 
            this.txtbxSaveLoc.Location = new System.Drawing.Point(193, 206);
            this.txtbxSaveLoc.Name = "txtbxSaveLoc";
            this.txtbxSaveLoc.Size = new System.Drawing.Size(322, 20);
            this.txtbxSaveLoc.TabIndex = 8;
            // 
            // btnExcel1
            // 
            this.btnExcel1.Location = new System.Drawing.Point(522, 39);
            this.btnExcel1.Name = "btnExcel1";
            this.btnExcel1.Size = new System.Drawing.Size(33, 20);
            this.btnExcel1.TabIndex = 9;
            this.btnExcel1.Text = "...";
            this.btnExcel1.UseVisualStyleBackColor = true;
            this.btnExcel1.Click += new System.EventHandler(this.btnExcel1_Click);
            // 
            // btnResx
            // 
            this.btnResx.Location = new System.Drawing.Point(522, 117);
            this.btnResx.Name = "btnResx";
            this.btnResx.Size = new System.Drawing.Size(33, 20);
            this.btnResx.TabIndex = 10;
            this.btnResx.Text = "...";
            this.btnResx.UseVisualStyleBackColor = true;
            this.btnResx.Click += new System.EventHandler(this.btnExcel1_Click);
            // 
            // btnSaveLoc
            // 
            this.btnSaveLoc.Location = new System.Drawing.Point(522, 206);
            this.btnSaveLoc.Name = "btnSaveLoc";
            this.btnSaveLoc.Size = new System.Drawing.Size(33, 20);
            this.btnSaveLoc.TabIndex = 12;
            this.btnSaveLoc.Text = "...";
            this.btnSaveLoc.UseVisualStyleBackColor = true;
            this.btnSaveLoc.Click += new System.EventHandler(this.btnSaveLoc_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(422, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data Range:";
            // 
            // txtRangeStart
            // 
            this.txtRangeStart.Location = new System.Drawing.Point(193, 78);
            this.txtRangeStart.Name = "txtRangeStart";
            this.txtRangeStart.Size = new System.Drawing.Size(56, 20);
            this.txtRangeStart.TabIndex = 15;
            // 
            // txtRangeEnd
            // 
            this.txtRangeEnd.Location = new System.Drawing.Point(292, 78);
            this.txtRangeEnd.Name = "txtRangeEnd";
            this.txtRangeEnd.Size = new System.Drawing.Size(56, 20);
            this.txtRangeEnd.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ex:- (A1 : B16) ,( C3 : D5).... etc";
            // 
            // btnGenerateScripts
            // 
            this.btnGenerateScripts.Location = new System.Drawing.Point(619, 34);
            this.btnGenerateScripts.Name = "btnGenerateScripts";
            this.btnGenerateScripts.Size = new System.Drawing.Size(75, 64);
            this.btnGenerateScripts.TabIndex = 18;
            this.btnGenerateScripts.Text = "Generate Sql Scripts";
            this.btnGenerateScripts.UseVisualStyleBackColor = true;
            this.btnGenerateScripts.Click += new System.EventHandler(this.btnGenerateScripts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 306);
            this.Controls.Add(this.btnGenerateScripts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRangeEnd);
            this.Controls.Add(this.txtRangeStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveLoc);
            this.Controls.Add(this.btnResx);
            this.Controls.Add(this.btnExcel1);
            this.Controls.Add(this.txtbxSaveLoc);
            this.Controls.Add(this.txtbxNewResxFileName);
            this.Controls.Add(this.txtbxResxFilePath);
            this.Controls.Add(this.txtbxExcelfileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtbxExcelfileName;
        private System.Windows.Forms.TextBox txtbxResxFilePath;
        private System.Windows.Forms.TextBox txtbxNewResxFileName;
        private System.Windows.Forms.TextBox txtbxSaveLoc;
        private System.Windows.Forms.Button btnExcel1;
        private System.Windows.Forms.Button btnResx;
        private System.Windows.Forms.Button btnSaveLoc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRangeStart;
        private System.Windows.Forms.TextBox txtRangeEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerateScripts;
    }
}


namespace ConvertXSLXtoXML {
    partial class Form2 {
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxTableName = new System.Windows.Forms.TextBox();
            this.txtbxOriginalTrans = new System.Windows.Forms.TextBox();
            this.lblPrimaryColumn = new System.Windows.Forms.Label();
            this.txtbxTargetTranslation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxFromCult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGenerateScripts = new System.Windows.Forms.Button();
            this.btnGetColumn = new System.Windows.Forms.Button();
            this.btnAddCol = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "item1",
            "item2",
            "item3"});
            this.listBox1.Location = new System.Drawing.Point(485, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(702, 49);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(198, 342);
            this.listBox2.TabIndex = 1;
            this.listBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table Name :";
            // 
            // txtbxTableName
            // 
            this.txtbxTableName.Location = new System.Drawing.Point(123, 49);
            this.txtbxTableName.Name = "txtbxTableName";
            this.txtbxTableName.Size = new System.Drawing.Size(256, 20);
            this.txtbxTableName.TabIndex = 3;
            // 
            // txtbxOriginalTrans
            // 
            this.txtbxOriginalTrans.Location = new System.Drawing.Point(123, 90);
            this.txtbxOriginalTrans.Name = "txtbxOriginalTrans";
            this.txtbxOriginalTrans.Size = new System.Drawing.Size(256, 20);
            this.txtbxOriginalTrans.TabIndex = 5;
            // 
            // lblPrimaryColumn
            // 
            this.lblPrimaryColumn.AutoSize = true;
            this.lblPrimaryColumn.Location = new System.Drawing.Point(17, 95);
            this.lblPrimaryColumn.Name = "lblPrimaryColumn";
            this.lblPrimaryColumn.Size = new System.Drawing.Size(103, 13);
            this.lblPrimaryColumn.TabIndex = 4;
            this.lblPrimaryColumn.Text = "Orginial Translation:";
            // 
            // txtbxTargetTranslation
            // 
            this.txtbxTargetTranslation.Location = new System.Drawing.Point(702, 12);
            this.txtbxTargetTranslation.Name = "txtbxTargetTranslation";
            this.txtbxTargetTranslation.Size = new System.Drawing.Size(158, 20);
            this.txtbxTargetTranslation.TabIndex = 7;
            this.txtbxTargetTranslation.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Translation N";
            this.label3.Visible = false;
            // 
            // txtbxFromCult
            // 
            this.txtbxFromCult.Location = new System.Drawing.Point(123, 11);
            this.txtbxFromCult.Name = "txtbxFromCult";
            this.txtbxFromCult.Size = new System.Drawing.Size(84, 20);
            this.txtbxFromCult.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "From Culture:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Script";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGenerateScripts
            // 
            this.btnGenerateScripts.Location = new System.Drawing.Point(244, 368);
            this.btnGenerateScripts.Name = "btnGenerateScripts";
            this.btnGenerateScripts.Size = new System.Drawing.Size(171, 23);
            this.btnGenerateScripts.TabIndex = 11;
            this.btnGenerateScripts.Text = "Generate Scripts";
            this.btnGenerateScripts.UseVisualStyleBackColor = true;
            this.btnGenerateScripts.Click += new System.EventHandler(this.btnGenerateScripts_Click);
            // 
            // btnGetColumn
            // 
            this.btnGetColumn.Location = new System.Drawing.Point(385, 47);
            this.btnGetColumn.Name = "btnGetColumn";
            this.btnGetColumn.Size = new System.Drawing.Size(94, 23);
            this.btnGetColumn.TabIndex = 12;
            this.btnGetColumn.Text = "Get Columns";
            this.btnGetColumn.UseVisualStyleBackColor = true;
            this.btnGetColumn.Click += new System.EventHandler(this.btnGetColumn_Click);
            // 
            // btnAddCol
            // 
            this.btnAddCol.Location = new System.Drawing.Point(385, 88);
            this.btnAddCol.Name = "btnAddCol";
            this.btnAddCol.Size = new System.Drawing.Size(94, 23);
            this.btnAddCol.TabIndex = 13;
            this.btnAddCol.Text = "Get Values";
            this.btnAddCol.UseVisualStyleBackColor = true;
            this.btnAddCol.Click += new System.EventHandler(this.btnAddCol_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(390, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "To Culture:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 403);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddCol);
            this.Controls.Add(this.btnGetColumn);
            this.Controls.Add(this.btnGenerateScripts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtbxFromCult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxTargetTranslation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxOriginalTrans);
            this.Controls.Add(this.lblPrimaryColumn);
            this.Controls.Add(this.txtbxTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxTableName;
        private System.Windows.Forms.TextBox txtbxOriginalTrans;
        private System.Windows.Forms.Label lblPrimaryColumn;
        private System.Windows.Forms.TextBox txtbxTargetTranslation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxFromCult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGenerateScripts;
        private System.Windows.Forms.Button btnGetColumn;
        private System.Windows.Forms.Button btnAddCol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}
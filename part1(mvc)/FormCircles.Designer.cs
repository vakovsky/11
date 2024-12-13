
namespace WindowsFormsApp1
{
    partial class FormCircles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonLoadAccessDB = new System.Windows.Forms.Button();
            this.buttonSaveAccessDB = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSaveJSON = new System.Windows.Forms.Button();
            this.buttonLoadJSON = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSaveXML = new System.Windows.Forms.Button();
            this.buttonLoadXML = new System.Windows.Forms.Button();
            this.buttonSaveMSSQLDB = new System.Windows.Forms.Button();
            this.buttonLoadMSSQLDB = new System.Windows.Forms.Button();
            this.buttonSaveCSV = new System.Windows.Forms.Button();
            this.buttonLoadCSV = new System.Windows.Forms.Button();
            this.buttonLoadMSSQLDBContext = new System.Windows.Forms.Button();
            this.buttonSaveMSSQLDBContext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(333, 290);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(362, 13);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(87, 23);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Create...";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(362, 41);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(87, 23);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "Read...";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(362, 70);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(87, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update...";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(362, 99);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(87, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete...";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 308);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(87, 23);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonLoadAccessDB
            // 
            this.buttonLoadAccessDB.Location = new System.Drawing.Point(634, 100);
            this.buttonLoadAccessDB.Name = "buttonLoadAccessDB";
            this.buttonLoadAccessDB.Size = new System.Drawing.Size(141, 23);
            this.buttonLoadAccessDB.TabIndex = 6;
            this.buttonLoadAccessDB.Text = "Load Access DB";
            this.buttonLoadAccessDB.UseVisualStyleBackColor = true;
            this.buttonLoadAccessDB.Click += new System.EventHandler(this.buttonLoadAccessDB_Click);
            // 
            // buttonSaveAccessDB
            // 
            this.buttonSaveAccessDB.Location = new System.Drawing.Point(487, 101);
            this.buttonSaveAccessDB.Name = "buttonSaveAccessDB";
            this.buttonSaveAccessDB.Size = new System.Drawing.Size(141, 23);
            this.buttonSaveAccessDB.TabIndex = 8;
            this.buttonSaveAccessDB.Text = "Save Access DB";
            this.buttonSaveAccessDB.UseVisualStyleBackColor = true;
            this.buttonSaveAccessDB.Click += new System.EventHandler(this.buttonSaveAccessDB_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(258, 308);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSaveJSON
            // 
            this.buttonSaveJSON.Location = new System.Drawing.Point(487, 13);
            this.buttonSaveJSON.Name = "buttonSaveJSON";
            this.buttonSaveJSON.Size = new System.Drawing.Size(141, 23);
            this.buttonSaveJSON.TabIndex = 13;
            this.buttonSaveJSON.Text = "Save JSON";
            this.buttonSaveJSON.UseVisualStyleBackColor = true;
            this.buttonSaveJSON.Click += new System.EventHandler(this.buttonSaveJSON_Click);
            // 
            // buttonLoadJSON
            // 
            this.buttonLoadJSON.Location = new System.Drawing.Point(634, 13);
            this.buttonLoadJSON.Name = "buttonLoadJSON";
            this.buttonLoadJSON.Size = new System.Drawing.Size(141, 23);
            this.buttonLoadJSON.TabIndex = 12;
            this.buttonLoadJSON.Text = "Load JSON";
            this.buttonLoadJSON.UseVisualStyleBackColor = true;
            this.buttonLoadJSON.Click += new System.EventHandler(this.buttonLoadJSON_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Location = new System.Drawing.Point(487, 43);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(141, 23);
            this.buttonSaveXML.TabIndex = 15;
            this.buttonSaveXML.Text = "Save XML";
            this.buttonSaveXML.UseVisualStyleBackColor = true;
            this.buttonSaveXML.Click += new System.EventHandler(this.buttonSaveXML_Click);
            // 
            // buttonLoadXML
            // 
            this.buttonLoadXML.Location = new System.Drawing.Point(634, 43);
            this.buttonLoadXML.Name = "buttonLoadXML";
            this.buttonLoadXML.Size = new System.Drawing.Size(141, 23);
            this.buttonLoadXML.TabIndex = 14;
            this.buttonLoadXML.Text = "Load XML";
            this.buttonLoadXML.UseVisualStyleBackColor = true;
            this.buttonLoadXML.Click += new System.EventHandler(this.buttonLoadXML_Click);
            // 
            // buttonSaveMSSQLDB
            // 
            this.buttonSaveMSSQLDB.Location = new System.Drawing.Point(487, 130);
            this.buttonSaveMSSQLDB.Name = "buttonSaveMSSQLDB";
            this.buttonSaveMSSQLDB.Size = new System.Drawing.Size(141, 23);
            this.buttonSaveMSSQLDB.TabIndex = 16;
            this.buttonSaveMSSQLDB.Text = "Save MSSQL DB";
            this.buttonSaveMSSQLDB.UseVisualStyleBackColor = true;
            this.buttonSaveMSSQLDB.Click += new System.EventHandler(this.buttonSaveMSSQLDB_Click);
            // 
            // buttonLoadMSSQLDB
            // 
            this.buttonLoadMSSQLDB.Location = new System.Drawing.Point(634, 130);
            this.buttonLoadMSSQLDB.Name = "buttonLoadMSSQLDB";
            this.buttonLoadMSSQLDB.Size = new System.Drawing.Size(141, 23);
            this.buttonLoadMSSQLDB.TabIndex = 17;
            this.buttonLoadMSSQLDB.Text = "Load MSSQL DB";
            this.buttonLoadMSSQLDB.UseVisualStyleBackColor = true;
            this.buttonLoadMSSQLDB.Click += new System.EventHandler(this.buttonLoadMSSQLDB_Click);
            // 
            // buttonSaveCSV
            // 
            this.buttonSaveCSV.Location = new System.Drawing.Point(487, 72);
            this.buttonSaveCSV.Name = "buttonSaveCSV";
            this.buttonSaveCSV.Size = new System.Drawing.Size(141, 23);
            this.buttonSaveCSV.TabIndex = 19;
            this.buttonSaveCSV.Text = "Save CSV";
            this.buttonSaveCSV.UseVisualStyleBackColor = true;
            this.buttonSaveCSV.Click += new System.EventHandler(this.buttonSaveCSV_Click);
            // 
            // buttonLoadCSV
            // 
            this.buttonLoadCSV.Location = new System.Drawing.Point(634, 71);
            this.buttonLoadCSV.Name = "buttonLoadCSV";
            this.buttonLoadCSV.Size = new System.Drawing.Size(141, 23);
            this.buttonLoadCSV.TabIndex = 18;
            this.buttonLoadCSV.Text = "Load CSV";
            this.buttonLoadCSV.UseVisualStyleBackColor = true;
            this.buttonLoadCSV.Click += new System.EventHandler(this.buttonLoadCSV_Click);
            // 
            // buttonLoadMSSQLDBContext
            // 
            this.buttonLoadMSSQLDBContext.Location = new System.Drawing.Point(634, 159);
            this.buttonLoadMSSQLDBContext.Name = "buttonLoadMSSQLDBContext";
            this.buttonLoadMSSQLDBContext.Size = new System.Drawing.Size(141, 23);
            this.buttonLoadMSSQLDBContext.TabIndex = 21;
            this.buttonLoadMSSQLDBContext.Text = "Load MSSQL DBContext";
            this.buttonLoadMSSQLDBContext.UseVisualStyleBackColor = true;
            this.buttonLoadMSSQLDBContext.Click += new System.EventHandler(this.buttonLoadMSSQLDBContext_Click);
            // 
            // buttonSaveMSSQLDBContext
            // 
            this.buttonSaveMSSQLDBContext.Location = new System.Drawing.Point(487, 159);
            this.buttonSaveMSSQLDBContext.Name = "buttonSaveMSSQLDBContext";
            this.buttonSaveMSSQLDBContext.Size = new System.Drawing.Size(141, 23);
            this.buttonSaveMSSQLDBContext.TabIndex = 20;
            this.buttonSaveMSSQLDBContext.Text = "Save MSSQL DBContext";
            this.buttonSaveMSSQLDBContext.UseVisualStyleBackColor = true;
            this.buttonSaveMSSQLDBContext.Click += new System.EventHandler(this.buttonSaveMSSQLDBContext_Click);
            // 
            // FormCircles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 382);
            this.Controls.Add(this.buttonLoadMSSQLDBContext);
            this.Controls.Add(this.buttonSaveMSSQLDBContext);
            this.Controls.Add(this.buttonSaveCSV);
            this.Controls.Add(this.buttonLoadCSV);
            this.Controls.Add(this.buttonLoadMSSQLDB);
            this.Controls.Add(this.buttonSaveMSSQLDB);
            this.Controls.Add(this.buttonSaveXML);
            this.Controls.Add(this.buttonLoadXML);
            this.Controls.Add(this.buttonSaveJSON);
            this.Controls.Add(this.buttonLoadJSON);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSaveAccessDB);
            this.Controls.Add(this.buttonLoadAccessDB);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.listBox1);
            this.Name = "FormCircles";
            this.Text = "FormCircles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonLoadAccessDB;
        private System.Windows.Forms.Button buttonSaveAccessDB;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSaveJSON;
        private System.Windows.Forms.Button buttonLoadJSON;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSaveXML;
        private System.Windows.Forms.Button buttonLoadXML;
        private System.Windows.Forms.Button buttonSaveMSSQLDB;
        private System.Windows.Forms.Button buttonLoadMSSQLDB;
        private System.Windows.Forms.Button buttonSaveCSV;
        private System.Windows.Forms.Button buttonLoadCSV;
        private System.Windows.Forms.Button buttonLoadMSSQLDBContext;
        private System.Windows.Forms.Button buttonSaveMSSQLDBContext;
    }
}

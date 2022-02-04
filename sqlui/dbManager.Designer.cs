namespace sqlui
{
    partial class dbManager
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
            this.lstTables = new System.Windows.Forms.ListBox();
            this.grpTools = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxTableName = new System.Windows.Forms.TextBox();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.grpTools.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTables
            // 
            this.lstTables.FormattingEnabled = true;
            this.lstTables.Location = new System.Drawing.Point(405, 18);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(148, 381);
            this.lstTables.TabIndex = 6;
            // 
            // grpTools
            // 
            this.grpTools.Controls.Add(this.tableView);
            this.grpTools.Controls.Add(this.groupBox1);
            this.grpTools.Location = new System.Drawing.Point(12, 12);
            this.grpTools.Name = "grpTools";
            this.grpTools.Size = new System.Drawing.Size(387, 387);
            this.grpTools.TabIndex = 5;
            this.grpTools.TabStop = false;
            this.grpTools.Text = "Outils";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxTableName);
            this.groupBox1.Controls.Add(this.btnCreateTable);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créer une table";
            // 
            // txtBoxTableName
            // 
            this.txtBoxTableName.Location = new System.Drawing.Point(6, 19);
            this.txtBoxTableName.Name = "txtBoxTableName";
            this.txtBoxTableName.Size = new System.Drawing.Size(233, 20);
            this.txtBoxTableName.TabIndex = 0;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(245, 19);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(124, 20);
            this.btnCreateTable.TabIndex = 1;
            this.btnCreateTable.Text = "Créer";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.BtnCreateTable_Click);
            // 
            // tableView
            // 
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Location = new System.Drawing.Point(6, 76);
            this.tableView.Name = "tableView";
            this.tableView.Size = new System.Drawing.Size(375, 305);
            this.tableView.TabIndex = 3;
            // 
            // dbManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 410);
            this.Controls.Add(this.lstTables);
            this.Controls.Add(this.grpTools);
            this.Name = "dbManager";
            this.Text = "dbManager";
            this.Load += new System.EventHandler(this.DbManager_Load);
            this.grpTools.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.GroupBox grpTools;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxTableName;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.DataGridView tableView;
    }
}
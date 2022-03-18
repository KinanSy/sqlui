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
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxTableName = new System.Windows.Forms.TextBox();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.grpTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTables
            // 
            this.lstTables.FormattingEnabled = true;
            this.lstTables.Location = new System.Drawing.Point(702, 12);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(148, 576);
            this.lstTables.TabIndex = 6;
            this.lstTables.SelectedIndexChanged += new System.EventHandler(this.LstTables_SelectedIndexChanged_1);
            // 
            // grpTools
            // 
            this.grpTools.Controls.Add(this.btnSaveData);
            this.grpTools.Controls.Add(this.btnDeleteTable);
            this.grpTools.Controls.Add(this.tableView);
            this.grpTools.Controls.Add(this.groupBox1);
            this.grpTools.Location = new System.Drawing.Point(12, 12);
            this.grpTools.Name = "grpTools";
            this.grpTools.Size = new System.Drawing.Size(684, 576);
            this.grpTools.TabIndex = 5;
            this.grpTools.TabStop = false;
            this.grpTools.Text = "Outils";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(6, 529);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(192, 41);
            this.btnSaveData.TabIndex = 4;
            this.btnSaveData.Text = "Effectuer les changements";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.BtnSaveData_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Enabled = false;
            this.btnDeleteTable.Location = new System.Drawing.Point(387, 24);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(132, 46);
            this.btnDeleteTable.TabIndex = 0;
            this.btnDeleteTable.Text = "Supprimer";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.BtnDeleteTable_Click);
            // 
            // tableView
            // 
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Location = new System.Drawing.Point(6, 76);
            this.tableView.Name = "tableView";
            this.tableView.Size = new System.Drawing.Size(672, 447);
            this.tableView.TabIndex = 3;
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
            // dbManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 604);
            this.Controls.Add(this.lstTables);
            this.Controls.Add(this.grpTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "dbManager";
            this.Text = "dbManager";
            this.Load += new System.EventHandler(this.DbManager_Load);
            this.grpTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.GroupBox grpTools;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxTableName;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnSaveData;
    }
}
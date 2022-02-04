namespace sqlui
{
    partial class tableManager
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
            this.pnlColumns = new System.Windows.Forms.Panel();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.btnAddCmn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlColumns
            // 
            this.pnlColumns.AutoScroll = true;
            this.pnlColumns.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlColumns.Controls.Add(this.label3);
            this.pnlColumns.Controls.Add(this.label2);
            this.pnlColumns.Controls.Add(this.label1);
            this.pnlColumns.Location = new System.Drawing.Point(12, 41);
            this.pnlColumns.Name = "pnlColumns";
            this.pnlColumns.Size = new System.Drawing.Size(528, 397);
            this.pnlColumns.TabIndex = 0;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(404, 444);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(136, 23);
            this.btnCreateTable.TabIndex = 1;
            this.btnCreateTable.Text = "Créer";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            // 
            // btnAddCmn
            // 
            this.btnAddCmn.Location = new System.Drawing.Point(427, 10);
            this.btnAddCmn.Name = "btnAddCmn";
            this.btnAddCmn.Size = new System.Drawing.Size(113, 23);
            this.btnAddCmn.TabIndex = 2;
            this.btnAddCmn.Text = "Ajouter des champs";
            this.btnAddCmn.UseVisualStyleBackColor = true;
            this.btnAddCmn.Click += new System.EventHandler(this.BtnAddCmn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(301, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taille";
            // 
            // tableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 473);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnAddCmn);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.pnlColumns);
            this.Name = "tableManager";
            this.Text = "Gestionnaire des tables []";
            this.Load += new System.EventHandler(this.TableManager_Load);
            this.pnlColumns.ResumeLayout(false);
            this.pnlColumns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlColumns;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnAddCmn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
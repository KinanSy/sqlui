namespace sqlui
{
    partial class mainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpTools = new System.Windows.Forms.GroupBox();
            this.btnDeleteDb = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstDatabases = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.grpTools.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(153, 40);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Se connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connexion : ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(487, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Déconnecté";
            // 
            // grpTools
            // 
            this.grpTools.Controls.Add(this.btnCreateUser);
            this.grpTools.Controls.Add(this.btnDeleteDb);
            this.grpTools.Controls.Add(this.groupBox1);
            this.grpTools.Location = new System.Drawing.Point(12, 58);
            this.grpTools.Name = "grpTools";
            this.grpTools.Size = new System.Drawing.Size(387, 387);
            this.grpTools.TabIndex = 3;
            this.grpTools.TabStop = false;
            this.grpTools.Text = "Outils";
            // 
            // btnDeleteDb
            // 
            this.btnDeleteDb.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteDb.Enabled = false;
            this.btnDeleteDb.Location = new System.Drawing.Point(6, 76);
            this.btnDeleteDb.Name = "btnDeleteDb";
            this.btnDeleteDb.Size = new System.Drawing.Size(375, 40);
            this.btnDeleteDb.TabIndex = 6;
            this.btnDeleteDb.Text = "Supprimer la base de données";
            this.btnDeleteDb.UseVisualStyleBackColor = true;
            this.btnDeleteDb.Click += new System.EventHandler(this.BtnDeleteDb_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créer une DB";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Créer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lstDatabases
            // 
            this.lstDatabases.FormattingEnabled = true;
            this.lstDatabases.Location = new System.Drawing.Point(405, 64);
            this.lstDatabases.Name = "lstDatabases";
            this.lstDatabases.Size = new System.Drawing.Size(148, 381);
            this.lstDatabases.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Double-cliquez pour ouvrir les bases de données";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCreateUser.Enabled = false;
            this.btnCreateUser.Location = new System.Drawing.Point(6, 122);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(375, 40);
            this.btnCreateUser.TabIndex = 7;
            this.btnCreateUser.Text = "Créer un utilisateur";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDatabases);
            this.Controls.Add(this.grpTools);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "MySQL Tools [Kinan JANO - 2022]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTools.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpTools;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstDatabases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteDb;
        private System.Windows.Forms.Button btnCreateUser;
    }
}


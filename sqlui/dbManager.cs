/*
 * ETML
 * Author       : Kinan JANO
 * Date         : 11.03.2022
 * Description  : Windows Forms Interface to manage databases. the form is opened after a database is double clicked
 *                in the main form. the user is able to view table names, the rows inside the table.
 *                he is also able to modify, delete and add new rows.
 */
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sqlui
{
    public partial class dbManager : Form
    {
        public string dbName;
        public MySqlConnection mysqlCon = mainForm.mysqlCon;
        BindingSource bSource;
        DataTable table;
        MySqlDataAdapter myDA;
        MySqlCommandBuilder builder;
        public dbManager(string _dbName)
        {
            InitializeComponent();
            dbName = _dbName;
            this.Text = "Gestionnaire des DB [" + dbName + "]";
            UpdateTableList();

        }
        public void UpdateTableList()
        {
            MySqlCommand command = new MySqlCommand("use " + dbName + ";", mysqlCon);
            command.ExecuteNonQuery();
            lstTables.Items.Clear();
            MySqlCommand cmd = mysqlCon.CreateCommand();
            cmd.CommandText = "SHOW TABLES;";
            MySqlDataReader Reader;
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                string row = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    row = Reader.GetValue(i).ToString();
                lstTables.Items.Add(row);
            }
            Reader.Close();
        }
        private void LstTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstTables.SelectedIndex != -1)
            {
                UpdateTableView(lstTables.SelectedItem.ToString());
            }
        }
        private void UpdateTableView(string tableName)
        {

            // Source https://stackoverflow.com/questions/12904854/fill-datagridview-with-mysql-data/25269906

            myDA = new MySqlDataAdapter();
            myDA.SelectCommand = new MySqlCommand(string.Format("SELECT * FROM `{0}`",tableName), mysqlCon);

            table = new DataTable();
            myDA.Fill(table);

            bSource = new BindingSource();
            bSource.DataSource = table;
            builder = new MySqlCommandBuilder(myDA);
            tableView.DataSource = bSource;
        }
        private void DbManager_Load(object sender, EventArgs e)
        {
            lstTables.SelectedIndexChanged += new EventHandler(LstTables_SelectedIndexChanged);
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {
            tableManager tblManager = new tableManager(txtBoxTableName.Text,dbName,this);
            tblManager.Show();
        }

        private void LstTables_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnDeleteTable.Enabled = !(lstTables.SelectedIndex == -1);
        }

        private void BtnDeleteTable_Click(object sender, EventArgs e)
        {
            string selectedTableName = lstTables.SelectedItem.ToString();
            try
            {
                MySqlCommand creationCommand = new MySqlCommand("DROP TABLE `"+selectedTableName+"`", mysqlCon);
                creationCommand.ExecuteNonQuery();
                MessageBox.Show("La table " + selectedTableName + " est supprimee");

                UpdateTableList();
                tableView.DataSource = null;
                tableView.Refresh();
                Refresh();
                btnDeleteTable.Enabled = !(lstTables.SelectedIndex == -1);
            }
            catch
            {
                MessageBox.Show("Nous avons pas pu supprimer la table "+selectedTableName);
            }

        }

        private void BtnSaveData_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Voulez-vous vraiement effectuer les changements dans la table?","Confirmation des changements",MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    bSource.EndEdit();
                    myDA.Update(table);
                    tableView.EndEdit();
                    MessageBox.Show("Les changements ont ete sauvegarde");
                }
                catch
                {
                    MessageBox.Show("Erreur lors du sauvegarde des changements.");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sqlui
{
    public partial class dbManager : Form
    {
        public string dbName;
        public MySqlConnection mysqlCon = Form1.mysqlCon;
        public dbManager(string _dbName)
        {
            InitializeComponent();
            dbName = _dbName;
            this.Text = "Gestionnaire des DB [" + dbName + "]";
            UpdateTableList();

        }
        private void UpdateTableList()
        {
            MySqlCommand command = new MySqlCommand("use " + dbName + ";", mysqlCon);
            command.ExecuteNonQuery();

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

            MySqlDataAdapter myDA = new MySqlDataAdapter();
            myDA.SelectCommand = new MySqlCommand(string.Format("SELECT * FROM {0}",tableName), mysqlCon);

            DataTable table = new DataTable();
            myDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            tableView.DataSource = bSource;
        }
        private void DbManager_Load(object sender, EventArgs e)
        {
            lstTables.SelectedIndexChanged += new EventHandler(LstTables_SelectedIndexChanged);
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {

            //verif regex a implementer

            tableManager tblManager = new tableManager(txtBoxTableName.Text);
            tblManager.Show();

        }
    }
}

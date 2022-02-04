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
using System.Text.RegularExpressions;

namespace sqlui
{

    public partial class Form1 : Form
    {
        public bool mysqlConState = false;
        public string mysqlHost = "localhost";
        public string mysqlUsername = "root";
        public string mysqlPassword = "root";
        public string mysqlDatabase = "";

        static public MySqlConnection mysqlCon;
        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshDBList()
        {
            MySqlCommand cmd = mysqlCon.CreateCommand();
            cmd.CommandText = "SHOW DATABASES;";
            MySqlDataReader Reader;
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                string row = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    row = Reader.GetValue(i).ToString();
                lstDatabases.Items.Add(row);
            }
            Reader.Close();
        }
        private void ToggleControls(bool enable)
        {
            foreach(Control control in grpTools.Controls)
            {
                control.Enabled = enable;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToggleControls(false);
            lstDatabases.DoubleClick += new EventHandler(Database_DoubleClick);
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (mysqlConState)
            {
                mysqlCon.Close();
                mysqlConState = false;
                lblStatus.Text = "Déconnecté";
                ToggleControls(false);
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                mysqlCon = new MySqlConnection(String.Format("SERVER={0};UID={1};PWD={2};DATABASE={3};", mysqlHost, mysqlUsername, mysqlPassword, mysqlDatabase));
                try
                {
                    mysqlCon.Open();
                    mysqlConState = true;
                    lblStatus.Text = "Connecté";
                    RefreshDBList();
                    ToggleControls(true);
                    lblStatus.ForeColor = Color.Green;


                }
                catch (Exception x)
                {
                    throw;

                }
            }
        }
        private void Database_DoubleClick(object sender, EventArgs e)
        {
            string selectedDbName = lstDatabases.SelectedItem.ToString();
            var dbManager = new dbManager(selectedDbName);
            dbManager.Show();

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string databaseName = textBox1.Text;
            Regex rx = new Regex(@"^\w+$");
            if (rx.IsMatch(databaseName))
            {
                MySqlCommand cmdNewDB = new MySqlCommand("CREATE DATABASE `"+ databaseName +"`", mysqlCon);
                cmdNewDB.ExecuteNonQuery();
                try
                {
                    MessageBox.Show(databaseName + " a ete cree!");
                    RefreshDBList();


                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
            else
            {
                MessageBox.Show("Seulement des chiffres et des lettres sont permis.");
            }
        }
    }
}

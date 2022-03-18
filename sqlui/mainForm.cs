/*
 * ETML
 * Author       : Kinan JANO
 * Date         : 11.03.2022
 * Description  : Main form of the program. the user is able to click the connect button, then the other functionnalities are enabled.
 *                the user can create and delete databases. he can also double click a database to manage it, and he's able to create
 *                MySQL users.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace sqlui
{
    /// <summary>
    /// Form1 class
    /// </summary>
    public partial class mainForm : Form
    {
        public bool mysqlConState = false;
        public string mysqlHost = "localhost";  // Nom d'hôte
        public string mysqlUsername = "root";   // Nom de l'utilisateur
        public string mysqlPassword = "root";   // Mot de passe de l'utilisateur
        public string mysqlDatabase = "";       // Nom de la base de données

        // Centeral connection variable to the DBS, used by other forms.
        static public MySqlConnection mysqlCon;
        /// <summary>
        /// Initializer of the form1
        /// </summary>
        public mainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Gets DATABASES from SGD and adds them into lstDatabases.
        /// </summary>
        private void RefreshDBList()
        {
            lstDatabases.Items.Clear();
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
                if(control != btnDeleteDb)
                    control.Enabled = enable;
            }
        }
        /// <summary>
        /// Add event handlers for lstDatabases double click and on index changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ToggleControls(false);
            lstDatabases.DoubleClick += new EventHandler(Database_DoubleClick);
            lstDatabases.SelectedIndexChanged += new EventHandler(Database_IndexChanged);
        }
        
        private void Database_IndexChanged(object sender, EventArgs e)
        {
            btnDeleteDb.Enabled = !(lstDatabases.SelectedIndex == -1);
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
                btnConnect.Text = "Se connecter";
                lstDatabases.Items.Clear();
            }
            else
            {
               
                try
                {
                    mysqlCon = new MySqlConnection(String.Format("SERVER={0};UID={1};PWD={2};DATABASE={3};convert zero datetime=True;", mysqlHost, mysqlUsername, mysqlPassword, mysqlDatabase));
                    mysqlCon.Open();
                    mysqlConState = true;
                    lblStatus.Text = "Connecté";
                    btnConnect.Text = "Se déconnecter";
                    RefreshDBList();
                    ToggleControls(true);
                    lblStatus.ForeColor = Color.Green;


                }
                catch (Exception x)
                {
                    MessageBox.Show("Connexion au serveur MYSQL impossible : \n" + x.Message);

                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                try
                {
                    MySqlCommand cmdNewDB = new MySqlCommand("CREATE DATABASE `" + databaseName + "`", mysqlCon);
                    cmdNewDB.ExecuteNonQuery();
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

        private void BtnDeleteDb_Click(object sender, EventArgs e)
        {
            string dbName = lstDatabases.SelectedItem.ToString();
            var confirmResult = MessageBox.Show("Voulez-vous vraiement supprimer la base de données?", "Confirmation de suppression de la base de données", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmdNewDB = new MySqlCommand("DROP DATABASE `" + dbName + "`", mysqlCon);
                    cmdNewDB.ExecuteNonQuery();
                    RefreshDBList();
                    btnDeleteDb.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Erreur lors de la suppression de la base de donnees.");
                }
            }
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            var createUseForm = new createUser();
            createUseForm.Show();
        }
    }
}

/*
 * ETML
 * Author       : Kinan JANO
 * Date         : 11.03.2022
 * Description  : Windows Forms Interface to create a MYSQL user. the interface user can type the username and the password.
 */
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace sqlui
{
    public partial class createUser : Form
    {
        public MySqlConnection mysqlCon = mainForm.mysqlCon;
        public createUser()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = maskedTextBox1.Text;
            try
            {
                MySqlCommand cmdNewDB = new MySqlCommand("CREATE USER '"+ username +"' IDENTIFIED BY '"+ password +"';", mysqlCon);
                cmdNewDB.ExecuteNonQuery();
                MessageBox.Show(username + " a ete cree!");
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}

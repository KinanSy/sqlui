/*
 * ETML
 * Author       : Kinan JANO
 * Date         : 11.03.2022
 * Description  : Windows Forms Interface to manage tables, the interface user is able to create tables,
 *                specify column names, types, and sizes. the user is also able to add as many columns
 *                as he wishes.
 */
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sqlui
{
    public partial class tableManager : Form
    {
        public string tableName;
        public string dbName;
        dbManager dbManager;
        public MySqlConnection mysqlCon = mainForm.mysqlCon;

        List<Control> tblColumnNames = new List<Control>();
        List<Control> tblColumnTypes = new List<Control>();
        List<NumericUpDown> tblColumnSizes = new List<NumericUpDown>();
        int tblColumnMargin = 25;
        public tableManager(string _tableName,string _dbName, dbManager _dbManager)
        {
            InitializeComponent();
            tableName = _tableName;
            dbName = _dbName;
            dbManager = _dbManager;
            this.Text = "Gestionnaire des tables ["+ tableName +"]";
        }
        public string GenerateTableCreationQuery()
        {
            MySqlCommand command = new MySqlCommand("use " + dbName + ";", mysqlCon);
            string query = "CREATE TABLE `"+tableName+"` (";
            for(int i = 0; i < tblColumnNames.Count; i++)
            {
                string _columnName = tblColumnNames[i].Text;
                string _columnType = tblColumnTypes[i].Text;
                int _columnSize = (int)tblColumnSizes[i].Value;
                if(_columnName != "")
                {
                    if (i != 0 && i < tblColumnNames.Count - 1)
                        query += ",";
                    if (_columnName != "" && _columnSize != 0)
                        query += string.Format("`{0}` {1}({2})", _columnName, _columnType, _columnSize);
                    else
                        query += string.Format("`{0}` {1}", _columnName, _columnType, _columnSize);
                }
            }
            query += ")";
            return query;
        }
        public void AddColumns(int x)
        {

            for(int i = 0; i < x; i++)
            {
                int lastCtrlY = 0;
                if(tblColumnNames.Count == 0)
                {
                    lastCtrlY = 13;
                }
                else
                {
                    lastCtrlY = tblColumnNames[tblColumnNames.Count - 1].Location.Y;
                }

                // Column name textbox creation
                TextBox tblColumnName = new TextBox();
                tblColumnName.Location = new Point(10,lastCtrlY + tblColumnMargin);
                tblColumnNames.Add(tblColumnName);

                // Column type listbox creation
                ComboBox tblColumnType = new ComboBox();
                tblColumnType.Location = new Point(120, lastCtrlY + tblColumnMargin);
                tblColumnType.Items.Add("int");
                tblColumnType.Items.Add("float");
                tblColumnType.Items.Add("varchar");
                tblColumnType.SelectedIndex = 1;
                tblColumnTypes.Add(tblColumnType);

                // Column Size numericUpDown creation
                NumericUpDown tblColumnSize = new NumericUpDown();
                tblColumnSize.Location = new Point(250, lastCtrlY + tblColumnMargin);
                tblColumnSizes.Add(tblColumnSize);


                // Add created controls to the panel's control list
                pnlColumns.Controls.Add(tblColumnName);
                pnlColumns.Controls.Add(tblColumnType);
                pnlColumns.Controls.Add(tblColumnSize);
            }
        }
        
        private void TableManager_Load(object sender, EventArgs e)
        {
            AddColumns(4);
        }

        private void BtnAddCmn_Click(object sender, EventArgs e)
        {
            AddColumns((int) numericUpDown1.Value);
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {
            string creationQuery = GenerateTableCreationQuery();
            
            try
            {
                MySqlCommand creationCommand = new MySqlCommand(creationQuery, mysqlCon);
                creationCommand.ExecuteNonQuery();
                this.Close();
                dbManager.UpdateTableList();
            }
            catch
            {
                MessageBox.Show("Erreur lors de la creation de la table : "+ creationQuery);
            }
        }
    }
}

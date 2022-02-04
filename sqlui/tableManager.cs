using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlui
{
    public partial class tableManager : Form
    {
        public string tableName;
        public MySqlConnection mysqlCon = Form1.mysqlCon;

        List<Control> tblColumnNames = new List<Control>();
        List<Control> tblColumnTypes = new List<Control>();
        List<Control> tblColumnSizes = new List<Control>();
        int tblColumnMargin = 25;
        public tableManager(string _tableName)
        {
            InitializeComponent();
            tableName = _tableName;
            this.Text = "Gestionnaire des tables ["+ tableName +"]";
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
    }
}

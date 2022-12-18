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

namespace HAHAton_project
{
    public partial class Main_Window : Form
    {
        public bool acces = false;
        public Main_Window()
        {
            InitializeComponent();

            if (acces != true) { Button_Workers.Visible = false; }
            
        }

        Authentication_Window AW;
        private void Form1_Load(object sender, EventArgs e)
        {
            INIManager manager = new INIManager("./app.ini");
            string check = manager.GetPrivateString("main", "enter");
            //acces = Convert.ToBoolean(manager.GetPrivateString("main", "access"));
            if (check != "true") {
                AW = new Authentication_Window { StartPosition = FormStartPosition.CenterParent };
                AW.ShowDialog();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlDataAdapter dataAdapter_services = new MySqlDataAdapter("SELECT * FROM Services", db.GetConnection());

            MySqlDataAdapter dataAdapter_orders = new MySqlDataAdapter("SELECT * FROM Orders", db.GetConnection());

            DataSet dataSet_services = new DataSet();

            DataSet dataSet_orders = new DataSet();

            dataAdapter_services.Fill(dataSet_services);

            dataAdapter_orders.Fill(dataSet_orders);

            dataGridView1.DataSource= dataSet_services.Tables[0];

            dataGridView2.DataSource= dataSet_orders.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //INIManager manager = new INIManager("./app.ini");
            //manager.GetHashCode();
        }
    }
}

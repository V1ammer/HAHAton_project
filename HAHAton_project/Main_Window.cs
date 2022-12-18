﻿using System;
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
            string check =manager.GetPrivateString("main", "enter");
            if (check != "true") {
                AW = new Authentication_Window { StartPosition = FormStartPosition.CenterParent };
                AW.ShowDialog();
            }
            
        }
    }
}

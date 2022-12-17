using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAHAton_project
{
    public partial class Authentication_Window : Form
    {
        public Authentication_Window()
        {
            InitializeComponent();

            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;
            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;
        }

        public bool enter_account = false;
        public String userLogin; public String userPass;

        private void Auth_button_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "" || passField.Text == "") MessageBox.Show("Не введён пароль или логин!", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (loginField.Text != "" && passField.Text != "")
            {
                String userLogin = loginField.Text;
                String userPass = passField.Text;

                DB db = new DB();

                db.OpenConnection();

                DataTable table = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand($"SELECT * FROM Users WHERE Login = '{@userLogin}' AND Password = '{@userPass}'", db.GetConnection());

                command.Parameters.Add("@userLogin", SqlDbType.VarChar).Value = userLogin;
                command.Parameters.Add("@userPass", SqlDbType.VarChar).Value = userPass;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Yes");
                    this.Close();
                }
                else
                    MessageBox.Show("No");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (enter_account == false) { Application.Exit(); }
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        Point lastPoint;
        private void Authentication_Window_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Authentication_Window_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
                
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        RemindPass_Window RemindW;
        private void RemindPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RemindW = new RemindPass_Window();
            RemindW.ShowDialog();
        }


        private void Button_helpDev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

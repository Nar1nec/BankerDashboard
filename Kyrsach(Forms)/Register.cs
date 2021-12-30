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

namespace Kyrsach_Forms_
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            NameBox1.Text = "Введите имя";
            NameBox1.ForeColor = Color.Gray;
            mailBox1.Text = "Введите почту";
            mailBox1.ForeColor = Color.Gray;
            LoginBox.Text = "Введите логин";
            LoginBox.ForeColor = Color.Gray;
            PasswordBox.Text = "Введите пароль";
            PasswordBox.ForeColor = Color.Gray;
        }

        private void NameBox1_Enter(object sender, EventArgs e)
        {
            
            if (NameBox1.Text == "Введите имя")
            {
                NameBox1.Text = "";
                NameBox1.ForeColor = Color.Black;
            }
            
        }

        private void NameBox1_Leave(object sender, EventArgs e)
        {
            if (NameBox1.Text == "") 
            {
                NameBox1.Text = "Введите имя";
                NameBox1.ForeColor = Color.Gray;
            }
        }

        private void registr_button_Click(object sender, EventArgs e)
        {

            if (NameBox1.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (mailBox1.Text == "Введите почту")
            {
                MessageBox.Show("Введите почту");
                return;
            }
            if (PasswordBox.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (LoginBox.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (IsUserExists())
                return;
            if (IsMailExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `mail`) VALUES (@login, @pass, @name, @mail)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginBox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordBox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameBox1.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mailBox1.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт создан");
            else
                MessageBox.Show("Аккаунт не был создан");
             
            db.closeConnection();
        }
        
        public Boolean IsUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginBox.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите другой");
                return true;
            }
            else
                return false;
        }

        public Boolean IsMailExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `mail` = @mail", db.getConnection());
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mailBox1.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такая почта уже существует, введите другую");
                return true;
            }
            else
                return false;
        }

        private void mailBox1_Enter(object sender, EventArgs e)
        {
            if (mailBox1.Text == "Введите почту")
            {
                mailBox1.Text = "";
                mailBox1.ForeColor = Color.Black;
            }
        }

        private void mailBox1_Leave(object sender, EventArgs e)
        {
            if (mailBox1.Text == "")
            {
                mailBox1.Text = "Введите почту";
                mailBox1.ForeColor = Color.Gray;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Authorization autorization = new Authorization();
            autorization.Show();
        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Введите логин")
            {
                LoginBox.Text = "";
                LoginBox.ForeColor = Color.Black;
            }
        }

        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                LoginBox.Text = "Введите логин";
                LoginBox.ForeColor = Color.Gray;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Введите пароль")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.Black;
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Введите пароль";
                PasswordBox.ForeColor = Color.Gray;
            }
        }
    }
}

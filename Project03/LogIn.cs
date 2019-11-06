using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project03
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            LocationForm();
            closeButton.Click += (s, e) => { Thread thread = new Thread(
                delegate () { Close(); });thread.Start(); };
            PasswordBox();

            username.Text = "Введите имя пользователя";
            username.ForeColor = Color.Gray;

            password.Text = "Введите пароль";
            password.ForeColor = Color.Gray;
        }
        private void LocationForm()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }
        private void PasswordBox()
        {
            password.TextChanged += (s, e) => { password.UseSystemPasswordChar = true; };
            showPassword.MouseDown += (s, e) => { password.UseSystemPasswordChar = false; };
            showPassword.MouseUp += (s, e) => {
                if (password.Text == "Введите пароль")
                    password.UseSystemPasswordChar = false;
                else
                    password.UseSystemPasswordChar = true;
            };
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Введите имя пользователя")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Введите имя пользователя";
                username.ForeColor = Color.Gray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if(password.Text == "Введите пароль")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Введите пароль";
                password.UseSystemPasswordChar = false;
                password.ForeColor = Color.Gray;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;
        }

        private void dontAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActiveForm.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            Close();
        }
    }
}

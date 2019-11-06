using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project03
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            LocationForm();
            closeButton.Click += (s, e) => { Thread thread = new Thread(() => { Close(); });
                thread.Start();
            };
            cmb_Gender.SelectedIndex = 0;
        }

        private void LocationForm()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2020, 05, 06, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;
            lblTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона";
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        OpenFileDialog openFile = new OpenFileDialog();
        private void Open()
        {
            try
            {
                openFile.InitialDirectory = @"C:\Users\magom\Pictures";
                openFile.Filter = "All Files (*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF|All Files (*.*)|*.*";
                openFile.FilterIndex = 2;
                if(openFile.ShowDialog() == DialogResult.OK)
                {
                    pictureRunner.Image = Image.FromFile(openFile.FileName);
                    pictureRunner.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureRunner.BorderStyle = BorderStyle.Fixed3D;
                    txt_Picture.Text = openFile.SafeFileName.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла ошибка. Уведомление системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_SelectPicture_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите покинуть окно регистрации?", "Оповещение системы!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                ActiveForm.Hide();
                LogIn logIn = new LogIn();
                logIn.ShowDialog();
                Close();
            }
        }
    }
}

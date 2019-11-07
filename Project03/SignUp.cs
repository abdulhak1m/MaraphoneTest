using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            PasswordBox(txt_Password, showPassword);
            PasswordBox(txt_ConfirmPassword, showConfirmPassword);
            txt_Password.TextChanged += (s, e) => { 
                if(txt_ConfirmPassword.Text != "")
                {
                    CheckPassword();
                }
            };
            txt_ConfirmPassword.TextChanged += (s, e) => {
                if (txt_Password.Text != "")
                    CheckPassword();
                else if (txt_ConfirmPassword.Focus() == false)
                    CheckPassword();
            };
        }

        private void LocationForm()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }
        private void CheckPassword()
        {
            if(txt_Password.Text != txt_ConfirmPassword.Text)
            {
                lblError.Text = "Внимание, пароли не совпадают!";
                btn_SignUp.Enabled = false;
            }
            else
            {
                lblError.Text = "";
                btn_SignUp.Enabled = true;
            }
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
        private void PasswordBox(TextBox text, Button button)
        {
            text.TextChanged += (s, e) => { text.UseSystemPasswordChar = true; };
            button.MouseDown += (s, e) => { text.UseSystemPasswordChar = false; };
            button.MouseUp += (s, e) => { text.UseSystemPasswordChar = true; };
        }
        public bool CheckPasswords()
        {
            bool digit = false;
            bool spec = false;
            bool lowChar = false;
            for (int i = 0; i < txt_Password.TextLength; i++)
            {
                if (char.IsDigit(txt_Password.Text[i]))
                {
                    digit = true;
                    break;
                }
            }
            for (int i = 0; i < txt_Password.TextLength; i++)
            {
                if (char.IsLower(txt_Password.Text[i]))
                {
                    spec = true;
                    break;
                }
            }
            for (int i = 0; i < txt_Password.TextLength; i++)
            {
                if (txt_Password.Text[i] == '#' || txt_Password.Text[i] == '!' || txt_Password.Text[i] == '@' || txt_Password.Text[i] == '$' || txt_Password.Text[i] == '%' || txt_Password.Text[i] == '^')
                {
                    spec = true;
                    break;
                }
            }
            if (digit == true && lowChar == true && spec == true)
                return true;
            else
                return false;
        }
        private async void btn_SignUp_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureRunner.Image.Save(stream, pictureRunner.Image.RawFormat);
            byte[] a = stream.GetBuffer();
            stream.Close();
            try
            {
                Regex emailRegex = new Regex(@"\w{2,10}@\w{2,10}.\w{2,10}");
                Match emailMatch = emailRegex.Match(txt_Email.Text);
                if (emailMatch.Value == "")
                    MessageBox.Show("Некорректный формат email!", "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    //bool digit = false;
                    //bool spec = false;
                    //bool lowChar = false;

                    //for (int i = 0; i < txt_Password.TextLength; i++)
                    //{
                    //    if (char.IsDigit(txt_Password.Text[i]))
                    //    {
                    //        digit = true;
                    //        break;
                    //    }
                    //}
                    //for (int i = 0; i < txt_Password.TextLength; i++)
                    //{
                    //    if (char.IsLower(txt_Password.Text[i]))
                    //    {
                    //        spec = true;
                    //        break;
                    //    }
                    //}
                    //for (int i = 0; i < txt_Password.TextLength; i++)
                    //{
                    //    if (txt_Password.Text[i] == '#' || txt_Password.Text[i] == '!' || txt_Password.Text[i] == '@' || txt_Password.Text[i] == '$' || txt_Password.Text[i] == '%' || txt_Password.Text[i] == '^')
                    //    {
                    //        spec = true;
                    //        break;
                    //    }
                    //}
                    if (txt_Password.TextLength <= 6 || !CheckPasswords())
                        MessageBox.Show("Некорректный формат пароля! Длина пароля должно быть не менее шести символов, из которых должна быть, как минимум, одна буква нижнего регистра, одна цифра и одна из следующих символов: !,#,%,^,@", "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        DateTime dateofbirth = Convert.ToDateTime(dtp_DateOfBirth.Value);
                        if (DateTime.Now.Year - dateofbirth.Year < 10)
                            MessageBox.Show("Возраст бегуна, на момент регистрации, должно быть не менее 10-ти лет.", "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            using (SqlConnection connection = new SqlConnection(Connection.GetString()))
                            {
                                await connection.OpenAsync();
                                string queryPersonalInfo = "INSERT INTO RunnerPersonalInfo VALUES (@n, @s, @g, @d, @c, @pn, @pc)";
                                SqlCommand command = new SqlCommand(queryPersonalInfo, connection);
                                command.Parameters.AddWithValue("@n", txt_Name.Text);
                                command.Parameters.AddWithValue("@s", txt_Surname.Text);
                                command.Parameters.AddWithValue("@g", cmb_Gender.Text);
                                command.Parameters.AddWithValue("@d", dtp_DateOfBirth.Value);
                                command.Parameters.AddWithValue("@c", cmb_Country.Text);
                                command.Parameters.AddWithValue("@pn", txt_Picture.Text);
                                command.Parameters.AddWithValue("@pc", a);
                                await command.ExecuteNonQueryAsync();

                                string queryConfidentialInfo = "INSERT INTO RunnerConfidentialInfo VALUES (@e, @u, @p)";
                                SqlCommand command1 = new SqlCommand(queryConfidentialInfo, connection);
                                command1.Parameters.AddWithValue("@e", txt_Email.Text);
                                command1.Parameters.AddWithValue("@u", txt_Username.Text);
                                command1.Parameters.AddWithValue("@p", txt_Password.Text);
                                await command1.ExecuteNonQueryAsync();

                                MessageBox.Show("Регистрация прошла успешно! Пожалуйста перейдите в окно авторизации.", "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

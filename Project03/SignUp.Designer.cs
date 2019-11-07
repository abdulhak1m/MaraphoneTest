namespace Project03
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.btn_SelectPicture = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gb_ConfidentialInfo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_PersonalInfo = new System.Windows.Forms.GroupBox();
            this.dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cmb_Country = new System.Windows.Forms.ComboBox();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureRunner = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Picture = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.showPassword = new System.Windows.Forms.Button();
            this.showConfirmPassword = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.gb_ConfidentialInfo.SuspendLayout();
            this.gb_PersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRunner)).BeginInit();
            this.pnlTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1366, 25);
            this.topPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::Project03.Properties.Resources.power_red_16;
            this.closeButton.Location = new System.Drawing.Point(1341, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // btn_SelectPicture
            // 
            this.btn_SelectPicture.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_SelectPicture.FlatAppearance.BorderSize = 0;
            this.btn_SelectPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectPicture.ForeColor = System.Drawing.Color.White;
            this.btn_SelectPicture.Location = new System.Drawing.Point(637, 264);
            this.btn_SelectPicture.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SelectPicture.Name = "btn_SelectPicture";
            this.btn_SelectPicture.Size = new System.Drawing.Size(142, 30);
            this.btn_SelectPicture.TabIndex = 1;
            this.btn_SelectPicture.Text = "Выбрать";
            this.btn_SelectPicture.UseVisualStyleBackColor = false;
            this.btn_SelectPicture.Click += new System.EventHandler(this.Btn_SelectPicture_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(83, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 5);
            this.panel2.TabIndex = 4;
            // 
            // txt_Username
            // 
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Username.Location = new System.Drawing.Point(83, 139);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(330, 20);
            this.txt_Username.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Email.Location = new System.Drawing.Point(83, 76);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(330, 20);
            this.txt_Email.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(83, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 5);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(554, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Регистрация Бегуна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(441, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пожалуйста, заполните все поля, отмеченные (*)";
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Password.Location = new System.Drawing.Point(83, 205);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(330, 20);
            this.txt_Password.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(83, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 5);
            this.panel3.TabIndex = 4;
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(83, 268);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(330, 20);
            this.txt_ConfirmPassword.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Location = new System.Drawing.Point(83, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 5);
            this.panel4.TabIndex = 4;
            // 
            // gb_ConfidentialInfo
            // 
            this.gb_ConfidentialInfo.Controls.Add(this.showConfirmPassword);
            this.gb_ConfidentialInfo.Controls.Add(this.showPassword);
            this.gb_ConfidentialInfo.Controls.Add(this.txt_Email);
            this.gb_ConfidentialInfo.Controls.Add(this.txt_Username);
            this.gb_ConfidentialInfo.Controls.Add(this.txt_Password);
            this.gb_ConfidentialInfo.Controls.Add(this.txt_ConfirmPassword);
            this.gb_ConfidentialInfo.Controls.Add(this.label6);
            this.gb_ConfidentialInfo.Controls.Add(this.label5);
            this.gb_ConfidentialInfo.Controls.Add(this.label4);
            this.gb_ConfidentialInfo.Controls.Add(this.lblError);
            this.gb_ConfidentialInfo.Controls.Add(this.label3);
            this.gb_ConfidentialInfo.Controls.Add(this.panel2);
            this.gb_ConfidentialInfo.Controls.Add(this.panel1);
            this.gb_ConfidentialInfo.Controls.Add(this.panel3);
            this.gb_ConfidentialInfo.Controls.Add(this.panel4);
            this.gb_ConfidentialInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_ConfidentialInfo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gb_ConfidentialInfo.Location = new System.Drawing.Point(12, 131);
            this.gb_ConfidentialInfo.Name = "gb_ConfidentialInfo";
            this.gb_ConfidentialInfo.Size = new System.Drawing.Size(493, 352);
            this.gb_ConfidentialInfo.TabIndex = 6;
            this.gb_ConfidentialInfo.TabStop = false;
            this.gb_ConfidentialInfo.Text = "Конфиденциальная информация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(80, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Подтвердите пароль*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(80, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Пароль*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(80, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Имя пользователя*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(80, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail*:";
            // 
            // gb_PersonalInfo
            // 
            this.gb_PersonalInfo.Controls.Add(this.txt_Name);
            this.gb_PersonalInfo.Controls.Add(this.txt_Surname);
            this.gb_PersonalInfo.Controls.Add(this.cmb_Gender);
            this.gb_PersonalInfo.Controls.Add(this.dtp_DateOfBirth);
            this.gb_PersonalInfo.Controls.Add(this.cmb_Country);
            this.gb_PersonalInfo.Controls.Add(this.txt_Picture);
            this.gb_PersonalInfo.Controls.Add(this.label10);
            this.gb_PersonalInfo.Controls.Add(this.label11);
            this.gb_PersonalInfo.Controls.Add(this.pictureRunner);
            this.gb_PersonalInfo.Controls.Add(this.label12);
            this.gb_PersonalInfo.Controls.Add(this.label9);
            this.gb_PersonalInfo.Controls.Add(this.btn_SelectPicture);
            this.gb_PersonalInfo.Controls.Add(this.label8);
            this.gb_PersonalInfo.Controls.Add(this.label7);
            this.gb_PersonalInfo.Controls.Add(this.panel5);
            this.gb_PersonalInfo.Controls.Add(this.panel6);
            this.gb_PersonalInfo.Controls.Add(this.panel9);
            this.gb_PersonalInfo.Controls.Add(this.panel7);
            this.gb_PersonalInfo.Controls.Add(this.panel8);
            this.gb_PersonalInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_PersonalInfo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gb_PersonalInfo.Location = new System.Drawing.Point(530, 131);
            this.gb_PersonalInfo.Name = "gb_PersonalInfo";
            this.gb_PersonalInfo.Size = new System.Drawing.Size(824, 388);
            this.gb_PersonalInfo.TabIndex = 6;
            this.gb_PersonalInfo.TabStop = false;
            this.gb_PersonalInfo.Text = "Ваша личная информация";
            // 
            // dtp_DateOfBirth
            // 
            this.dtp_DateOfBirth.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_DateOfBirth.CalendarForeColor = System.Drawing.Color.RoyalBlue;
            this.dtp_DateOfBirth.CalendarTitleForeColor = System.Drawing.Color.RoyalBlue;
            this.dtp_DateOfBirth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DateOfBirth.Location = new System.Drawing.Point(40, 260);
            this.dtp_DateOfBirth.Name = "dtp_DateOfBirth";
            this.dtp_DateOfBirth.Size = new System.Drawing.Size(330, 27);
            this.dtp_DateOfBirth.TabIndex = 7;
            this.dtp_DateOfBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cmb_Country
            // 
            this.cmb_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Country.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Country.FormattingEnabled = true;
            this.cmb_Country.Items.AddRange(new object[] {
            "Россия",
            "США",
            "Финляндия",
            "Испания",
            "Греция",
            "Италия",
            "Франция",
            "Монако",
            "Германия",
            "Великобритания",
            "Австрия",
            "Австралия",
            "Исландия",
            "Ирландия",
            "Камерун",
            "Индия",
            "Швейцария",
            "Швеция"});
            this.cmb_Country.Location = new System.Drawing.Point(40, 319);
            this.cmb_Country.Name = "cmb_Country";
            this.cmb_Country.Size = new System.Drawing.Size(333, 29);
            this.cmb_Country.TabIndex = 6;
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Gender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Не выбрано",
            "Мужской",
            "Женский"});
            this.cmb_Gender.Location = new System.Drawing.Point(40, 185);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(333, 29);
            this.cmb_Gender.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(437, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Фотография*:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(37, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Страна*:";
            // 
            // pictureRunner
            // 
            this.pictureRunner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureRunner.Location = new System.Drawing.Point(614, 91);
            this.pictureRunner.Name = "pictureRunner";
            this.pictureRunner.Size = new System.Drawing.Size(194, 150);
            this.pictureRunner.TabIndex = 5;
            this.pictureRunner.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(37, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Дата рождения*:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(37, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Пол*:";
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Name.Location = new System.Drawing.Point(40, 55);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(330, 20);
            this.txt_Name.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(37, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Фамилия*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(37, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Имя*:";
            // 
            // txt_Picture
            // 
            this.txt_Picture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Picture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Picture.Location = new System.Drawing.Point(440, 270);
            this.txt_Picture.Name = "txt_Picture";
            this.txt_Picture.Size = new System.Drawing.Size(169, 20);
            this.txt_Picture.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Location = new System.Drawing.Point(40, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 5);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Location = new System.Drawing.Point(40, 77);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(330, 5);
            this.panel6.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel9.Location = new System.Drawing.Point(40, 348);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(330, 5);
            this.panel9.TabIndex = 4;
            // 
            // txt_Surname
            // 
            this.txt_Surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Surname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Surname.Location = new System.Drawing.Point(40, 118);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(330, 20);
            this.txt_Surname.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Location = new System.Drawing.Point(40, 214);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(330, 5);
            this.panel7.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel8.Location = new System.Drawing.Point(440, 292);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(169, 5);
            this.panel8.TabIndex = 4;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_SignUp.FlatAppearance.BorderSize = 0;
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_SignUp.Location = new System.Drawing.Point(537, 557);
            this.btn_SignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(142, 30);
            this.btn_SignUp.TabIndex = 1;
            this.btn_SignUp.Text = "Регистрация";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(687, 557);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(142, 30);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // pnlTime
            // 
            this.pnlTime.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlTime.Controls.Add(this.lblTime);
            this.pnlTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTime.ForeColor = System.Drawing.Color.White;
            this.pnlTime.Location = new System.Drawing.Point(0, 660);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(1366, 48);
            this.pnlTime.TabIndex = 7;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(1366, 48);
            this.lblTime.TabIndex = 0;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // showPassword
            // 
            this.showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword.FlatAppearance.BorderSize = 0;
            this.showPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.Image = global::Project03.Properties.Resources.icons8_visible_16;
            this.showPassword.Location = new System.Drawing.Point(409, 196);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(25, 25);
            this.showPassword.TabIndex = 6;
            this.showPassword.UseVisualStyleBackColor = false;
            // 
            // showConfirmPassword
            // 
            this.showConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showConfirmPassword.FlatAppearance.BorderSize = 0;
            this.showConfirmPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.showConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showConfirmPassword.Image = global::Project03.Properties.Resources.icons8_visible_16;
            this.showConfirmPassword.Location = new System.Drawing.Point(409, 265);
            this.showConfirmPassword.Name = "showConfirmPassword";
            this.showConfirmPassword.Size = new System.Drawing.Size(25, 25);
            this.showConfirmPassword.TabIndex = 6;
            this.showConfirmPassword.UseVisualStyleBackColor = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(80, 171);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 5;
            // 
            // SignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 708);
            this.Controls.Add(this.gb_ConfidentialInfo);
            this.Controls.Add(this.gb_PersonalInfo);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_SignUp);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.topPanel.ResumeLayout(false);
            this.gb_ConfidentialInfo.ResumeLayout(false);
            this.gb_ConfidentialInfo.PerformLayout();
            this.gb_PersonalInfo.ResumeLayout(false);
            this.gb_PersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRunner)).EndInit();
            this.pnlTime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_SelectPicture;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gb_ConfidentialInfo;
        private System.Windows.Forms.GroupBox gb_PersonalInfo;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Picture;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureRunner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_DateOfBirth;
        private System.Windows.Forms.ComboBox cmb_Country;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button showConfirmPassword;
        private System.Windows.Forms.Button showPassword;
        private System.Windows.Forms.Label lblError;
    }
}
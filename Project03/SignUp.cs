using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            closeButton.Click += (s, e) => { Close(); };
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
    }
}

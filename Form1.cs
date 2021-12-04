using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGenerator
{
    public partial class landingPage : Form
    {
        public landingPage()
        {
            InitializeComponent();
        }

        int start, stop, Gstart, Gstop;

        private void LandingPage_Load(object sender, EventArgs e)
        {
            start = 0001;
            stop = 1000;
            Gstart = 0001;
            Gstop = 1000;
        }

        private void GenerateNumber_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Random randNum = new Random();
            for (int i = 0; i <= 400; i++)
            {
                number.Text = randNum.Next(start, stop).ToString();
            }
            timer.Stop();
            
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guna2ImageButton1_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = true;
            settingsPanel.Enabled = true;
            numStart.Focus();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            start = Convert.ToInt32(numStart.Text.Trim().ToString());
            stop = Convert.ToInt32(numStop.Text.Trim().ToString());
            //Gstart = Convert.ToInt32(GNumStart.Text.Trim().ToString());
            //Gstop = Convert.ToInt32(GNumStop.Text.Trim().ToString());
            settingsPanel.Visible = false; ;
            settingsPanel.Enabled = false;
        }
    }
}

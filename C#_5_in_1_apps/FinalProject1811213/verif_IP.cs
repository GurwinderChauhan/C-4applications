using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace FinalProject1811213
{
    public partial class IP4_Validator : Form
    {
        
        public IP4_Validator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Regex objRegex = new Regex(@"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b");

            if (objRegex.IsMatch(maskedTextBox1.Text.Trim()) == true)
            {
                MessageBox.Show("The IP is correct.");
            }
            else
            {
                MessageBox.Show("The IP must have 4 bytes integer number between 0 to 255 seperated by a dot (255.255.255.255)");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to quit!", "Close App", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = new DateTime();
            datetime = DateTime.Now;
            this.label3.Text = "Today :"+datetime.ToString("MM.dd.yyyy");
        }

        
    }
}

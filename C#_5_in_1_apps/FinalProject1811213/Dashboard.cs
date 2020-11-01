using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1811213
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Lottomax lm = new Lottomax();
			lm.ShowDialog();
			pictureBox1.Focus();
			pictureBox1.Select();

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Lotto649 l649 = new Lotto649();
			l649.ShowDialog();
			pictureBox2.Focus();

		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Calculator cl = new Calculator();
			cl.ShowDialog();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			MoneyExchange me = new MoneyExchange();
			me.ShowDialog();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			TemperatureConversion tp = new TemperatureConversion();
			tp.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you really want to quit!", "Close App", MessageBoxButtons.YesNo).ToString() == "Yes")
			{
				this.Close();
			}
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			IP4_Validator ip = new IP4_Validator();
			ip.ShowDialog();
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{

		}
	}
}

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
	public partial class Calculator : Form
	{

		double operand1;
		string op = "";
		bool first = false;
		public Calculator()
		{
			InitializeComponent();
		}

		private void button18_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you really want to quit!", "Close App", MessageBoxButtons.YesNo).ToString() == "Yes")
			{
				this.Close();
			}
		}

		

		private void button17_Click(object sender, EventArgs e)
		{
			

				this.textBox1.Text = "0";
			
			
		}

		
		private void n1(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || first == true )
			{
				textBox1.Text = "1";
				first = false;
			}
			else
			{
				textBox1.Text = textBox1.Text + "1";
			}
		}

		private void n2(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || first == true)
			{
				textBox1.Text = "2";
				first = false;
			}
			else
			{
				textBox1.Text = textBox1.Text + "2";
			}
		}

		private void n3(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || first == true)
			{
				textBox1.Text = "3";
				first = false;
			}
			else
			{
				textBox1.Text = textBox1.Text + "3";
			}
		}

		private void n4(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || first == true)
			{
				textBox1.Text = "4";
				first = false;
			}
			else
			{
				textBox1.Text = textBox1.Text + "4";
			}
		}

		private void n6(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || first == true)
			{
				textBox1.Text = "6";
				first = false;
			}
			else
			{
				textBox1.Text = textBox1.Text + "6";
			}
		}

		private void n7(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || first == true)
			{
				textBox1.Text = "7";
				first = false;
			}
			else
			{
				textBox1.Text = textBox1.Text + "7";
			}
		}

		private void n8(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || first == true)
			{
				textBox1.Text = "8";
				first = false;
			}
			else
			{
				textBox1.Text = textBox1.Text + "8";
			}
		}

		private void n9(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || first == true)
			{
				textBox1.Text = "9";
				first = false;
			}
			else
			{
				textBox1.Text = textBox1.Text + "9";
			}
		}

		private void n0(object sender, EventArgs e)
		{
			
				textBox1.Text = textBox1.Text + "0";
			
		}

		private void nd(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + ".";
		}

		private void n5(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || first == true)
			{
				textBox1.Text = "5";
				first = false;
			}
			else
			{
				textBox1.Text = textBox1.Text + "5";
			}
		}

	

		private void button6_Click(object sender, EventArgs e)
		{
			operand1 = Convert.ToDouble(textBox1.Text);
			textBox1.Text = Convert.ToDouble(textBox1.Text) + "";
			op = "+";
			first = true;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			operand1 = Convert.ToDouble(textBox1.Text);
			textBox1.Text = Convert.ToDouble(textBox1.Text) + "";
			op = "-";
			first = true;

		}

		private void button12_Click(object sender, EventArgs e)
		{
			operand1 = Convert.ToDouble(textBox1.Text);
			textBox1.Text = Convert.ToDouble(textBox1.Text) + "";
			op = "*";
			first = true;
		}

		private void button15_Click(object sender, EventArgs e)
		{
			operand1 = Convert.ToDouble(textBox1.Text);
			textBox1.Text = Convert.ToDouble(textBox1.Text) + "";
			op = "/";
			first = true;
		}

		private void button16_Click(object sender, EventArgs e)
		{
			double operand2;
			double currentValue;

			operand2 = Convert.ToDouble(textBox1.Text);

			if (op == "+")
			{
				currentValue = (operand1 + operand2);
				textBox1.Text = Convert.ToString(currentValue);
				operand1 = currentValue;
			}

			if(op == "-")
			{
				currentValue = (operand1 - operand2);
				textBox1.Text = Convert.ToString(currentValue);
				operand1 = currentValue;
			}

			if(op == "*")
			{
				currentValue = (operand1 * operand2);
				textBox1.Text = Convert.ToString(currentValue);
				operand1 = currentValue;
			}

			if(op == "/")
			{
				if (operand2 == 0)
				{
					textBox1.Text =  "You cannot divide with zero";
				}
				else
				{
					currentValue = (operand1 / operand2);
					textBox1.Text = Convert.ToString(currentValue);
					operand1 = currentValue;
				}
			}
		}
	}
}

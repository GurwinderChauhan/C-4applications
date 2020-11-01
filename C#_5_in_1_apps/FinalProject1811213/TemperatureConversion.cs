using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject1811213
{
	public partial class TemperatureConversion : Form
	{
		string dirPath = @"..\..\..\TempConv.text";
		public TemperatureConversion()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (fromctof.Checked)
				{
					double c = Convert.ToDouble(ctxt.Text);
					ftxt.Text = Convert.ToString((c * 1.8) + 32);
					if (c == 100)
					{
						messagetxt.Text = "Water boils";
					}
					if (c == 40)
					{
						messagetxt.Text = "Hot Bath";
					}
					if (c == 37)
					{
						messagetxt.Text = "Body temperature";
					}
					if (c == 30)
					{
						messagetxt.Text = "Beach Weather";
					}
					if (c == 21)
					{
						messagetxt.Text = "Room Temerature";
					}
					if (c == 10)
					{
						messagetxt.Text = "Cool Day";
					}
					if (c == 0)
					{
						messagetxt.Text = "Freezing point of water";
					}
					if (c == -18)
					{
						messagetxt.Text = "Very Cold Day";
					}
					if (c == -40)
					{
						messagetxt.Text = "Extremely Cold Day \n (and the same number!)";
					}
				}

				if (fromftoc.Checked)
				{
					double f = Convert.ToDouble(ctxt.Text);
					ftxt.Text = Convert.ToString((f - 32) / 1.8);

					if (f == 212)
					{
						messagetxt.Text = "Water boils";
					}
					if (f == 104)
					{
						messagetxt.Text = "Hot Bath";
					}
					if (f == 98.6)
					{
						messagetxt.Text = "Body temperature";
					}
					if (f == 86)
					{
						messagetxt.Text = "Beach Weather";
					}
					if (f == 70)
					{
						messagetxt.Text = "Room Temerature";
					}
					if (f == 50)
					{
						messagetxt.Text = "Cool Day";
					}
					if (f == 32)
					{
						messagetxt.Text = "Freezing point of water";
					}
					if (f == 0)
					{
						messagetxt.Text = "Very Cold Day";
					}
					if (f == -40)
					{
						messagetxt.Text = "Extremely Cold Day \n (and the same number!)";
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Please select the appropriate temperature!");
			}


			FileStream fs = null;
			string filePath = dirPath;
			DateTime datetime = DateTime.Now;

			try
			{
				fs = new FileStream(filePath, FileMode.Append);
				StreamWriter textOut = new StreamWriter(fs);
				if (fromctof.Checked)
				{
					textOut.Write(ctxt.Text + "C" + "=" + ftxt.Text + "F" + " " + datetime + "\n");
				}
				if (fromftoc.Checked)
				{
					textOut.Write(ctxt.Text + "F" + "=" + ftxt.Text + "C" + " " + datetime + "\n");
				}
				//textOut.Write(" - \n  - " + messagetxt.Text);
				textOut.Close();

			}
			catch (FileNotFoundException)
			{
				MessageBox.Show(filePath + "not found" + "File not found");
			}
			catch (DirectoryNotFoundException)
			{
				MessageBox.Show(dirPath + "not found" + "File not found");
			}
			catch (IOException ex)
			{
				MessageBox.Show(ex.Message + "IOException");
			}
			finally
			{
				if (fs != null) fs.Close();
			}
		}
	

		private void button3_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to quit!", "Close App", MessageBoxButtons.YesNo).ToString() == "Yes")
			{
				this.Close();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(File.ReadAllText(@"..\..\..\TempConv.text"), "Gurwinder", MessageBoxButtons.OK);
		}

		private void fromftoc_CheckedChanged(object sender, EventArgs e)
		{
			
			label2.Text = "F";
			label3.Text = "C";

		}

		private void fromctof_CheckedChanged(object sender, EventArgs e)
		{
			label2.Text = "C";
			label3.Text = "F";
		}
	}
}

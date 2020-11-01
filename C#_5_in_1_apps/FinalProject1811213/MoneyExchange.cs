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
	public partial class MoneyExchange : Form
	{

		string dirPath = @"..\..\..\MoneyExchange.text";
		
		public MoneyExchange()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to quit application Money Exchange?", "Close App", MessageBoxButtons.YesNo).ToString() == "Yes")
			{
				this.Close();
			}
		}


		private void converttxt_Click(object sender, EventArgs e)
		{
			
			try
			{
				if (Fcad.Checked && tcad.Checked)
				{
					resulttxt.Text = amounttxt.Text;
				}

				if (Fcad.Checked && tusd.Checked)
				{
					double amountusd = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amountusd*0.71);
				}

				if (Fcad.Checked && teur.Checked)
				{
					double amounteur = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amounteur * 0.64);
				}

				if (Fcad.Checked && tgbp.Checked)
				{
					double amountgbp = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amountgbp * 0.57);
				}

				if (Fcad.Checked && tn.Checked)
				{
					double amountnt = Convert.ToDouble(amounttxt.Text);
					//resulttxt.Text = Convert.ToString("Select the right currency!");
					MessageBox.Show("Please select a currency!");
				}
			}
			catch
			{
				MessageBox.Show("Please enter the amount!!!");
			}


			try
			{
				if (fusd.Checked && tcad.Checked)
				{
					double amountcad = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amountcad * 1.42);
				}

				if (fusd.Checked && tusd.Checked)
				{
					double amountusd = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amountusd);
				}

				if (fusd.Checked && teur.Checked)
				{
					double amounteur = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amounteur * 0.91);
				}

				if (fusd.Checked && tgbp.Checked)
				{
					double amountgbp = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amountgbp * 0.81);
				}

				if (fusd.Checked && tn.Checked)
				{
					double amountnt = Convert.ToDouble(amounttxt.Text);
					//resulttxt.Text = Convert.ToString("Select the right currency!");
					MessageBox.Show("Please select a currency!");
				}
			}
			catch
			{
				MessageBox.Show("Please enter the amount!!!");
			}

			try
			{
				if (feur.Checked && tcad.Checked)
				{
					double amountcad = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amountcad * 1.56);
				}

				if (feur.Checked && tusd.Checked)
				{
					double amountusd = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amountusd * 1.10);
				}

				if (feur.Checked && teur.Checked)
				{
					double amounteur = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amounteur);
				}

				if (feur.Checked && tgbp.Checked)
				{
					double amountgbp = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amountgbp * 0.89);
				}

				if (feur.Checked && tn.Checked)
				{
					double amountnt = Convert.ToDouble(amounttxt.Text);
					//resulttxt.Text = Convert.ToString("Select the right currency!");
					MessageBox.Show("Please select a currency!");
				}
			}
			catch
			{
				MessageBox.Show("Please enter the amount!!!");
			}

			try
			{
				if (fgbp.Checked && tcad.Checked)
				{
					double amountcad = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amountcad * 1.75);
				}

				if (fgbp.Checked && tusd.Checked)
				{
					double amountusd = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amountusd * 1.24);
				}

				if (fgbp.Checked && teur.Checked)
				{
					double amounteur = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amounteur * 1.12);
				}

				if (fgbp.Checked && tgbp.Checked)
				{
					double amountgbp = Convert.ToDouble(amounttxt.Text);
					resulttxt.Text = Convert.ToString(amountgbp);
				}

				if (fgbp.Checked && tn.Checked)
				{
					double amountnt = Convert.ToDouble(amounttxt.Text);
					//resulttxt.Text = Convert.ToString("Select the right currency!");
					MessageBox.Show("Please select a currency!");
				}
			}
			catch
			{
				MessageBox.Show("Please enter the amount!!!");
			}

			if (fn.Checked)
			{
				MessageBox.Show( "Please select the currency you want to convert!");
			}


			FileStream fs = null;
			string filePath = dirPath;
			DateTime datetime = DateTime.Now;


			try
			{
				fs = new FileStream(filePath, FileMode.Append);
				StreamWriter textOut = new StreamWriter(fs);
				if (Fcad.Checked && tcad.Checked)
				{
					textOut.Write(amounttxt.Text + "CAD" + "=" + resulttxt.Text + "CAD" + " " + datetime + "\n");
				}
				if (Fcad.Checked && tusd.Checked)
				{
					textOut.Write(amounttxt.Text + "CAD" + "=" + resulttxt.Text + "USD" + " " + datetime + "\n");
				}

				if (Fcad.Checked && teur.Checked)
				{
					textOut.Write(amounttxt.Text + "CAD" + "=" + resulttxt.Text + "EUR" + " " + datetime + "\n");
				}

				if (Fcad.Checked && tgbp.Checked)
				{
					textOut.Write(amounttxt.Text + "CAD" + "=" + resulttxt.Text + "GBP" + " " + datetime + "\n");
				}

				if (Fcad.Checked && tn.Checked)
				{
					textOut.Write(amounttxt.Text + "CAD" + "=" + resulttxt.Text + "?" + " " + datetime + "\n");
				}


				if (fusd.Checked && tcad.Checked)
				{
					textOut.Write(amounttxt.Text + "USD" + "=" + resulttxt.Text + "CAD" + " " + datetime + "\n");
				}

				if (fusd.Checked && tusd.Checked)
				{
					textOut.Write(amounttxt.Text + "USD" + "=" + resulttxt.Text + "USD" + " " + datetime + "\n");
				}

				if (fusd.Checked && teur.Checked)
				{
					textOut.Write(amounttxt.Text + "USD" + "=" + resulttxt.Text + "EUR" + " " + datetime + "\n");
				}

				if (fusd.Checked && tgbp.Checked)
				{
					textOut.Write(amounttxt.Text + "USD" + "=" + resulttxt.Text + "GBP" + " " + datetime + "\n");
				}

				if (fusd.Checked && tn.Checked)
				{
					textOut.Write(amounttxt.Text + "USD" + "=" + resulttxt.Text + "?" + " " + datetime + "\n");
				}


				if (feur.Checked && tcad.Checked)
				{
					textOut.Write(amounttxt.Text + "EUR" + "=" + resulttxt.Text + "CAD" + " " + datetime + "\n");
				}

				if (feur.Checked && tusd.Checked)
				{
					textOut.Write(amounttxt.Text + "EUR" + "=" + resulttxt.Text + "USD" + " " + datetime + "\n");
				}

				if (feur.Checked && teur.Checked)
				{
					textOut.Write(amounttxt.Text + "EUR" + "=" + resulttxt.Text + "EUR" + " " + datetime + "\n");
				}

				if (feur.Checked && tgbp.Checked)
				{
					textOut.Write(amounttxt.Text + "EUR" + "=" + resulttxt.Text + "GBP" + " " + datetime + "\n");
				}

				if (feur.Checked && tn.Checked)
				{
					textOut.Write(amounttxt.Text + "EUR" + "=" + resulttxt.Text + "?" + " " + datetime + "\n");
				}


				if (fgbp.Checked && tcad.Checked)
				{
					textOut.Write(amounttxt.Text + "GBP" + "=" + resulttxt.Text + "CAD" + " " + datetime + "\n");
				}

				if (fgbp.Checked && tusd.Checked)
				{
					textOut.Write(amounttxt.Text + "GBP" + "=" + resulttxt.Text + "USD" + " " + datetime + "\n");
				}

				if (fgbp.Checked && teur.Checked)
				{
					textOut.Write(amounttxt.Text + "GBP" + "=" + resulttxt.Text + "EUR" + " " + datetime + "\n");
				}

				if (fgbp.Checked && tgbp.Checked)
				{
					textOut.Write(amounttxt.Text + "GBP" + "=" + resulttxt.Text + "GBP" + " " + datetime + "\n");
				}

				if (fgbp.Checked && tn.Checked)
				{
					textOut.Write(amounttxt.Text + "GBP" + "=" + resulttxt.Text + "?" + " " + datetime + "\n");
				}
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

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(File.ReadAllText(@"..\..\..\MoneyExchange.text"), "Gurwinder", MessageBoxButtons.OK);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			
		}
	}
}

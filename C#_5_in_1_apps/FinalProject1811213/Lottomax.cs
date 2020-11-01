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
	public partial class Lottomax : Form
	{
		string dirPath = @"..\..\..\Lottomax.text";
		public Lottomax()
		{
			InitializeComponent();
		}

		private void generatetxt_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			string space = Environment.NewLine;
			int randomNumber = random.Next(1, 50);
			this.messagetxt.Text = randomNumber.ToString();

			for (int i = 1; i <= 7; i++)
			{
				randomNumber = random.Next(1, 50);
				messagetxt.Text = messagetxt.Text + space + randomNumber.ToString();
			}




			FileStream fs = null;
			string filePath = dirPath;
			DateTime datetime = DateTime.Now;

			try
			{
				fs = new FileStream(filePath, FileMode.Append);
				StreamWriter textOut = new StreamWriter(fs);
				textOut.Write("Max;" + datetime + ";" + messagetxt.Text + ";" + "Bonus " + messagetxt.Text[8] + "\n");

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

		private void readtxt_Click(object sender, EventArgs e)
		{
			MessageBox.Show(File.ReadAllText(@"..\..\..\Lottomax.Text"),"Gurwinder", MessageBoxButtons.OK);
		}

		private void Exittxt_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to quit!", "Close App", MessageBoxButtons.YesNo).ToString() == "Yes")
			{
				this.Close();
			}
		}
	}
	}


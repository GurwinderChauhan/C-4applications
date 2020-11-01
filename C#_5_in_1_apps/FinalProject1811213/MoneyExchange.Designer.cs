namespace FinalProject1811213
{
	partial class MoneyExchange
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fn = new System.Windows.Forms.RadioButton();
            this.fgbp = new System.Windows.Forms.RadioButton();
            this.feur = new System.Windows.Forms.RadioButton();
            this.fusd = new System.Windows.Forms.RadioButton();
            this.Fcad = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tn = new System.Windows.Forms.RadioButton();
            this.tgbp = new System.Windows.Forms.RadioButton();
            this.teur = new System.Windows.Forms.RadioButton();
            this.tusd = new System.Windows.Forms.RadioButton();
            this.tcad = new System.Windows.Forms.RadioButton();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.resulttxt = new System.Windows.Forms.TextBox();
            this.converttxt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fn);
            this.groupBox1.Controls.Add(this.fgbp);
            this.groupBox1.Controls.Add(this.feur);
            this.groupBox1.Controls.Add(this.fusd);
            this.groupBox1.Controls.Add(this.Fcad);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // fn
            // 
            this.fn.AutoSize = true;
            this.fn.Location = new System.Drawing.Point(16, 163);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(31, 17);
            this.fn.TabIndex = 6;
            this.fn.TabStop = true;
            this.fn.Text = "?";
            this.fn.UseVisualStyleBackColor = true;
            // 
            // fgbp
            // 
            this.fgbp.AutoSize = true;
            this.fgbp.Location = new System.Drawing.Point(16, 131);
            this.fgbp.Name = "fgbp";
            this.fgbp.Size = new System.Drawing.Size(47, 17);
            this.fgbp.TabIndex = 5;
            this.fgbp.TabStop = true;
            this.fgbp.Text = "GBP";
            this.fgbp.UseVisualStyleBackColor = true;
            // 
            // feur
            // 
            this.feur.AutoSize = true;
            this.feur.Location = new System.Drawing.Point(16, 96);
            this.feur.Name = "feur";
            this.feur.Size = new System.Drawing.Size(48, 17);
            this.feur.TabIndex = 4;
            this.feur.TabStop = true;
            this.feur.Text = "EUR";
            this.feur.UseVisualStyleBackColor = true;
            // 
            // fusd
            // 
            this.fusd.AutoSize = true;
            this.fusd.Location = new System.Drawing.Point(16, 60);
            this.fusd.Name = "fusd";
            this.fusd.Size = new System.Drawing.Size(48, 17);
            this.fusd.TabIndex = 3;
            this.fusd.TabStop = true;
            this.fusd.Text = "USD";
            this.fusd.UseVisualStyleBackColor = true;
            // 
            // Fcad
            // 
            this.Fcad.AutoSize = true;
            this.Fcad.Location = new System.Drawing.Point(16, 28);
            this.Fcad.Name = "Fcad";
            this.Fcad.Size = new System.Drawing.Size(47, 17);
            this.Fcad.TabIndex = 2;
            this.Fcad.TabStop = true;
            this.Fcad.Text = "CAD";
            this.Fcad.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tn);
            this.groupBox2.Controls.Add(this.tgbp);
            this.groupBox2.Controls.Add(this.teur);
            this.groupBox2.Controls.Add(this.tusd);
            this.groupBox2.Controls.Add(this.tcad);
            this.groupBox2.Location = new System.Drawing.Point(200, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // tn
            // 
            this.tn.AutoSize = true;
            this.tn.Location = new System.Drawing.Point(27, 163);
            this.tn.Name = "tn";
            this.tn.Size = new System.Drawing.Size(31, 17);
            this.tn.TabIndex = 11;
            this.tn.TabStop = true;
            this.tn.Text = "?";
            this.tn.UseVisualStyleBackColor = true;
            // 
            // tgbp
            // 
            this.tgbp.AutoSize = true;
            this.tgbp.Location = new System.Drawing.Point(27, 131);
            this.tgbp.Name = "tgbp";
            this.tgbp.Size = new System.Drawing.Size(47, 17);
            this.tgbp.TabIndex = 10;
            this.tgbp.TabStop = true;
            this.tgbp.Text = "GBP";
            this.tgbp.UseVisualStyleBackColor = true;
            // 
            // teur
            // 
            this.teur.AutoSize = true;
            this.teur.Location = new System.Drawing.Point(27, 96);
            this.teur.Name = "teur";
            this.teur.Size = new System.Drawing.Size(48, 17);
            this.teur.TabIndex = 9;
            this.teur.TabStop = true;
            this.teur.Text = "EUR";
            this.teur.UseVisualStyleBackColor = true;
            // 
            // tusd
            // 
            this.tusd.AutoSize = true;
            this.tusd.Location = new System.Drawing.Point(27, 60);
            this.tusd.Name = "tusd";
            this.tusd.Size = new System.Drawing.Size(48, 17);
            this.tusd.TabIndex = 8;
            this.tusd.TabStop = true;
            this.tusd.Text = "USD";
            this.tusd.UseVisualStyleBackColor = true;
            // 
            // tcad
            // 
            this.tcad.AutoSize = true;
            this.tcad.Location = new System.Drawing.Point(27, 28);
            this.tcad.Name = "tcad";
            this.tcad.Size = new System.Drawing.Size(47, 17);
            this.tcad.TabIndex = 7;
            this.tcad.TabStop = true;
            this.tcad.Text = "CAD";
            this.tcad.UseVisualStyleBackColor = true;
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(29, 264);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(108, 20);
            this.amounttxt.TabIndex = 12;
            // 
            // resulttxt
            // 
            this.resulttxt.Location = new System.Drawing.Point(200, 264);
            this.resulttxt.Name = "resulttxt";
            this.resulttxt.ReadOnly = true;
            this.resulttxt.Size = new System.Drawing.Size(123, 20);
            this.resulttxt.TabIndex = 13;
            // 
            // converttxt
            // 
            this.converttxt.Location = new System.Drawing.Point(29, 311);
            this.converttxt.Name = "converttxt";
            this.converttxt.Size = new System.Drawing.Size(84, 23);
            this.converttxt.TabIndex = 14;
            this.converttxt.Text = "&Convert";
            this.converttxt.UseVisualStyleBackColor = true;
            this.converttxt.Click += new System.EventHandler(this.converttxt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "&Read File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "E&xit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MoneyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.converttxt);
            this.Controls.Add(this.resulttxt);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MoneyExchange";
            this.Text = "Money Exchange";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton fn;
		private System.Windows.Forms.RadioButton fgbp;
		private System.Windows.Forms.RadioButton feur;
		private System.Windows.Forms.RadioButton fusd;
		private System.Windows.Forms.RadioButton Fcad;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton tn;
		private System.Windows.Forms.RadioButton tgbp;
		private System.Windows.Forms.RadioButton teur;
		private System.Windows.Forms.RadioButton tusd;
		private System.Windows.Forms.RadioButton tcad;
		private System.Windows.Forms.TextBox amounttxt;
		private System.Windows.Forms.TextBox resulttxt;
		private System.Windows.Forms.Button converttxt;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}
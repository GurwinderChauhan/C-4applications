namespace FinalProject1811213
{
	partial class TemperatureConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctxt = new System.Windows.Forms.TextBox();
            this.ftxt = new System.Windows.Forms.TextBox();
            this.messagetxt = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fromctof = new System.Windows.Forms.RadioButton();
            this.fromftoc = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Message:";
            // 
            // ctxt
            // 
            this.ctxt.Location = new System.Drawing.Point(12, 80);
            this.ctxt.Name = "ctxt";
            this.ctxt.Size = new System.Drawing.Size(100, 20);
            this.ctxt.TabIndex = 6;
            // 
            // ftxt
            // 
            this.ftxt.Location = new System.Drawing.Point(177, 80);
            this.ftxt.Name = "ftxt";
            this.ftxt.ReadOnly = true;
            this.ftxt.Size = new System.Drawing.Size(100, 20);
            this.ftxt.TabIndex = 7;
            // 
            // messagetxt
            // 
            this.messagetxt.Location = new System.Drawing.Point(12, 168);
            this.messagetxt.Name = "messagetxt";
            this.messagetxt.ReadOnly = true;
            this.messagetxt.Size = new System.Drawing.Size(265, 71);
            this.messagetxt.TabIndex = 8;
            this.messagetxt.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "&Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "&Read File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "E&xit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fromctof
            // 
            this.fromctof.AutoSize = true;
            this.fromctof.Location = new System.Drawing.Point(100, 22);
            this.fromctof.Name = "fromctof";
            this.fromctof.Size = new System.Drawing.Size(79, 17);
            this.fromctof.TabIndex = 12;
            this.fromctof.TabStop = true;
            this.fromctof.Text = "From C to F";
            this.fromctof.UseVisualStyleBackColor = true;
            this.fromctof.CheckedChanged += new System.EventHandler(this.fromctof_CheckedChanged);
            // 
            // fromftoc
            // 
            this.fromftoc.AutoSize = true;
            this.fromftoc.Location = new System.Drawing.Point(100, 45);
            this.fromftoc.Name = "fromftoc";
            this.fromftoc.Size = new System.Drawing.Size(79, 17);
            this.fromftoc.TabIndex = 13;
            this.fromftoc.TabStop = true;
            this.fromftoc.Text = "From F to C";
            this.fromftoc.UseVisualStyleBackColor = true;
            this.fromftoc.CheckedChanged += new System.EventHandler(this.fromftoc_CheckedChanged);
            // 
            // TemperatureConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 318);
            this.Controls.Add(this.fromftoc);
            this.Controls.Add(this.fromctof);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.messagetxt);
            this.Controls.Add(this.ftxt);
            this.Controls.Add(this.ctxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TemperatureConversion";
            this.Text = "Temperature Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ctxt;
		private System.Windows.Forms.TextBox ftxt;
		private System.Windows.Forms.RichTextBox messagetxt;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.RadioButton fromctof;
		private System.Windows.Forms.RadioButton fromftoc;
	}
}
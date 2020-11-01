namespace FinalProject1811213
{
	partial class Lottomax
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
            this.messagetxt = new System.Windows.Forms.RichTextBox();
            this.Exittxt = new System.Windows.Forms.Button();
            this.readtxt = new System.Windows.Forms.Button();
            this.generatetxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The winning number are:";
            // 
            // messagetxt
            // 
            this.messagetxt.Location = new System.Drawing.Point(15, 64);
            this.messagetxt.Name = "messagetxt";
            this.messagetxt.ReadOnly = true;
            this.messagetxt.Size = new System.Drawing.Size(266, 118);
            this.messagetxt.TabIndex = 10;
            this.messagetxt.Text = "";
            // 
            // Exittxt
            // 
            this.Exittxt.Location = new System.Drawing.Point(207, 212);
            this.Exittxt.Name = "Exittxt";
            this.Exittxt.Size = new System.Drawing.Size(75, 23);
            this.Exittxt.TabIndex = 15;
            this.Exittxt.Text = "E&xit";
            this.Exittxt.UseVisualStyleBackColor = true;
            this.Exittxt.Click += new System.EventHandler(this.Exittxt_Click);
            // 
            // readtxt
            // 
            this.readtxt.Location = new System.Drawing.Point(109, 212);
            this.readtxt.Name = "readtxt";
            this.readtxt.Size = new System.Drawing.Size(75, 23);
            this.readtxt.TabIndex = 14;
            this.readtxt.Text = "&Read File";
            this.readtxt.UseVisualStyleBackColor = true;
            this.readtxt.Click += new System.EventHandler(this.readtxt_Click);
            // 
            // generatetxt
            // 
            this.generatetxt.Location = new System.Drawing.Point(16, 212);
            this.generatetxt.Name = "generatetxt";
            this.generatetxt.Size = new System.Drawing.Size(75, 23);
            this.generatetxt.TabIndex = 13;
            this.generatetxt.Text = "&Generate";
            this.generatetxt.UseVisualStyleBackColor = true;
            this.generatetxt.Click += new System.EventHandler(this.generatetxt_Click);
            // 
            // Lottomax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 271);
            this.Controls.Add(this.Exittxt);
            this.Controls.Add(this.readtxt);
            this.Controls.Add(this.generatetxt);
            this.Controls.Add(this.messagetxt);
            this.Controls.Add(this.label1);
            this.Name = "Lottomax";
            this.Text = "Lottomax";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox messagetxt;
        private System.Windows.Forms.Button Exittxt;
        private System.Windows.Forms.Button readtxt;
        private System.Windows.Forms.Button generatetxt;
    }
}
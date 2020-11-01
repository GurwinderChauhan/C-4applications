namespace FinalProject1811213
{
	partial class Lotto649
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
            this.generatetxt = new System.Windows.Forms.Button();
            this.readtxt = new System.Windows.Forms.Button();
            this.Exittxt = new System.Windows.Forms.Button();
            this.messagetxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The winning number is: ";
            // 
            // generatetxt
            // 
            this.generatetxt.Location = new System.Drawing.Point(36, 203);
            this.generatetxt.Name = "generatetxt";
            this.generatetxt.Size = new System.Drawing.Size(75, 23);
            this.generatetxt.TabIndex = 10;
            this.generatetxt.Text = "&Generate";
            this.generatetxt.UseVisualStyleBackColor = true;
            this.generatetxt.Click += new System.EventHandler(this.generatetxt_Click);
            // 
            // readtxt
            // 
            this.readtxt.Location = new System.Drawing.Point(133, 203);
            this.readtxt.Name = "readtxt";
            this.readtxt.Size = new System.Drawing.Size(75, 23);
            this.readtxt.TabIndex = 11;
            this.readtxt.Text = "&Read File";
            this.readtxt.UseVisualStyleBackColor = true;
            this.readtxt.Click += new System.EventHandler(this.readtxt_Click);
            // 
            // Exittxt
            // 
            this.Exittxt.Location = new System.Drawing.Point(231, 203);
            this.Exittxt.Name = "Exittxt";
            this.Exittxt.Size = new System.Drawing.Size(75, 23);
            this.Exittxt.TabIndex = 12;
            this.Exittxt.Text = "E&xit";
            this.Exittxt.UseVisualStyleBackColor = true;
            this.Exittxt.Click += new System.EventHandler(this.Exittxt_Click);
            // 
            // messagetxt
            // 
            this.messagetxt.Location = new System.Drawing.Point(36, 62);
            this.messagetxt.Name = "messagetxt";
            this.messagetxt.ReadOnly = true;
            this.messagetxt.Size = new System.Drawing.Size(266, 118);
            this.messagetxt.TabIndex = 13;
            this.messagetxt.Text = "";
            // 
            // Lotto649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 261);
            this.Controls.Add(this.messagetxt);
            this.Controls.Add(this.Exittxt);
            this.Controls.Add(this.readtxt);
            this.Controls.Add(this.generatetxt);
            this.Controls.Add(this.label1);
            this.Name = "Lotto649";
            this.Text = "Lotto649";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button generatetxt;
		private System.Windows.Forms.Button readtxt;
		private System.Windows.Forms.Button Exittxt;
        private System.Windows.Forms.RichTextBox messagetxt;
    }
}
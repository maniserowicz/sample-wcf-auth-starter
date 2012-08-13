namespace Procent.Samples.WcfAuthStarter.Client.WinForms
{
	partial class FrmLogin
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
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Button btnLogin;
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			btnLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(9, 105);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(55, 13);
			label1.TabIndex = 0;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(11, 131);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(53, 13);
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// btnLogin
			// 
			btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
			btnLogin.Location = new System.Drawing.Point(70, 150);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new System.Drawing.Size(161, 23);
			btnLogin.TabIndex = 3;
			btnLogin.Text = "Log in";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(70, 124);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(161, 20);
			this.tbPassword.TabIndex = 4;
			this.tbPassword.Text = "LovesPiggyPig";
			// 
			// tbUsername
			// 
			this.tbUsername.Location = new System.Drawing.Point(70, 98);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(161, 20);
			this.tbUsername.TabIndex = 5;
			this.tbUsername.Text = "KermitFrog";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(24, 12);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(207, 80);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "Defined users:\r\n1;KermitFrog;LovesPiggyPig\r\n2;CarmenElectra;ElectrifyMe\r\n";
			// 
			// FrmLogin
			// 
			this.AcceptButton = btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(240, 182);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.tbUsername);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(btnLogin);
			this.Controls.Add(label2);
			this.Controls.Add(label1);
			this.Name = "FrmLogin";
			this.Text = "FrmLogin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.TextBox textBox1;
	}
}
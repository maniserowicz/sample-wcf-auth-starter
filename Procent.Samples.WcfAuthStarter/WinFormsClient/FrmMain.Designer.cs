namespace Procent.Samples.WcfAuthStarter.Client.WinForms
{
	partial class FrmMain
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
			this.lbRoles = new System.Windows.Forms.ListBox();
			this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
			this.Placeholder = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// lbRoles
			// 
			this.lbRoles.FormattingEnabled = true;
			this.lbRoles.Location = new System.Drawing.Point(12, 211);
			this.lbRoles.Name = "lbRoles";
			this.lbRoles.Size = new System.Drawing.Size(242, 95);
			this.lbRoles.TabIndex = 1;
			// 
			// buttonsPanel
			// 
			this.buttonsPanel.ColumnCount = 1;
			this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.buttonsPanel.Location = new System.Drawing.Point(12, 12);
			this.buttonsPanel.Name = "buttonsPanel";
			this.buttonsPanel.RowCount = 5;
			this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.buttonsPanel.Size = new System.Drawing.Size(150, 193);
			this.buttonsPanel.TabIndex = 2;
			// 
			// Placeholder
			// 
			this.Placeholder.Location = new System.Drawing.Point(179, 12);
			this.Placeholder.Name = "Placeholder";
			this.Placeholder.Size = new System.Drawing.Size(482, 193);
			this.Placeholder.TabIndex = 3;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 323);
			this.Controls.Add(this.Placeholder);
			this.Controls.Add(this.buttonsPanel);
			this.Controls.Add(this.lbRoles);
			this.Name = "FrmMain";
			this.Text = "FrmMain";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbRoles;
		private System.Windows.Forms.TableLayoutPanel buttonsPanel;
		private System.Windows.Forms.Panel Placeholder;
	}
}
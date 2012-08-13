namespace Procent.Samples.WcfAuthStarter.Client.WinForms.OperationsUI
{
	partial class ViewProducts
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
			this.gridProducts = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// gridProducts
			// 
			this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridProducts.Location = new System.Drawing.Point(24, 3);
			this.gridProducts.Name = "gridProducts";
			this.gridProducts.Size = new System.Drawing.Size(407, 177);
			this.gridProducts.TabIndex = 0;
			// 
			// ViewProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gridProducts);
			this.Name = "ViewProducts";
			this.Size = new System.Drawing.Size(450, 183);
			this.Load += new System.EventHandler(this.ViewProducts_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridProducts;
	}
}
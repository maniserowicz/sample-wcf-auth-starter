namespace Procent.Samples.WcfAuthStarter.Client.WinForms.OperationsUI
{
	partial class AddProduct
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			this.btnAdd = new System.Windows.Forms.Button();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(52, 65);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(149, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "OK";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(11, 16);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(35, 13);
			label1.TabIndex = 1;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(11, 42);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(31, 13);
			label2.TabIndex = 2;
			label2.Text = "Price";
			// 
			// tbPrice
			// 
			this.tbPrice.Location = new System.Drawing.Point(52, 39);
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(149, 20);
			this.tbPrice.TabIndex = 3;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(52, 13);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(149, 20);
			this.tbName.TabIndex = 4;
			// 
			// AddProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(label2);
			this.Controls.Add(label1);
			this.Controls.Add(this.btnAdd);
			this.Name = "AddProduct";
			this.Size = new System.Drawing.Size(215, 98);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox tbPrice;
		private System.Windows.Forms.TextBox tbName;
	}
}

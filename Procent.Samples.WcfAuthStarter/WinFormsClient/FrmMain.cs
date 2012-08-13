using System;
using System.Linq;
using System.Windows.Forms;
using Procent.Samples.WcfAuthStarter.Client.WinForms.UserOperations;
using Procent.Samples.WcfAuthStarter.Common.Security;

namespace Procent.Samples.WcfAuthStarter.Client.WinForms
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
			lbRoles.Items.Clear();
			foreach (string role in ProcentPrincipal.Current.Roles)
			{
				lbRoles.Items.Add(role);
			}
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			LoadOperations();
		}

		private void LoadOperations()
		{
			var operations = UserOperationDiscovery.Perform();
			operations.ToList().ForEach(
				o =>
					{
						// new button for each operation
						Button btn = new Button
						             	{
						             		Text = o.Value.DisplayName,
						             		Dock = DockStyle.Fill,
						             		Tag = o.Key
						             	};

						btn.Click += (s, e) =>
						             	{
						             		// dispose of currently displayed operation
						             		if (Placeholder.Controls.Count > 0)
						             			Placeholder.Controls[0].Dispose();
						             		Placeholder.Controls.Clear();

						             		// create new instance of operation on each click
						             		var newControl = (Control)Activator.CreateInstance((Type)btn.Tag);
						             		newControl.Dock = DockStyle.Fill;
						             		Placeholder.Controls.Add(newControl);
						             	};

						this.buttonsPanel.Controls.Add(btn);
					});
		}
	}
}
using System.Windows.Forms;

namespace Procent.Samples.WcfAuthStarter.Client.WinForms
{
	public partial class FrmLogin : Form
	{
		public string UserName { get { return tbUsername.Text; } }
		public string Password { get { return tbPassword.Text; } }

		public FrmLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
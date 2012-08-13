using System;
using System.Threading;
using System.Windows.Forms;
using Procent.Samples.WcfAuthStarter.Common.Security;
using Procent.Samples.WcfAuthStarter.ServiceContracts;

namespace Procent.Samples.WcfAuthStarter.Client.WinForms
{
	static class StartWinFormsClient
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			AppDomain.CurrentDomain.UnhandledException += (s, e) => HandleException(e.ExceptionObject as Exception);
			Application.ThreadException += (s, e) => HandleException(e.Exception);

			using (var loginForm = new FrmLogin())
			{
				if (loginForm.ShowDialog() != DialogResult.OK)
					return;

				CurrentData.Credentials.Username = loginForm.UserName;
				CurrentData.Credentials.Password = loginForm.Password;

				string[] roles = ServiceProxyProvider<ISecurityService>.Invoke(x => x.GetRoles());
				Thread.CurrentPrincipal = new ProcentPrincipal(new ProcentIdentity(-1, CurrentData.Credentials.Username), roles);
			}

			Application.Run(new FrmMain());
		}

		public static void HandleException(Exception exc)
		{
			MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
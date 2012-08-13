using System;
using System.Windows.Forms;
using Procent.Samples.WcfAuthStarter.Client.Core;

namespace Procent.Samples.WcfAuthStarter.Client.WinForms
{
	public class ServiceProxyProvider<TService> where TService : class
	{
		public static void Invoke(Action<TService> operation)
		{
			using (var proxy = new ServiceProxy<TService>())
			{
				proxy.ClientCredentials.UserName.UserName = CurrentData.Credentials.Username;
				proxy.ClientCredentials.UserName.Password = CurrentData.Credentials.Password;

				WaitingCursor(
					() => operation(proxy.GetChannel())
					);
			}
		}

		public static TResult Invoke<TResult>(Func<TService, TResult> operation)
		{
			TResult result = default(TResult);

			Invoke(x =>
			       	{
			       		result = operation(x);
			       	});

			return result;
		}

		private static void WaitingCursor(Action operation)
		{
			Form activeForm = Form.ActiveForm;

			if (activeForm != null)
			{
				activeForm.Cursor = Cursors.WaitCursor;
			}

			try
			{
				operation();
			}
			finally
			{
				if (activeForm != null)
					activeForm.Cursor = Cursors.Default;
			}
		}
	}
}
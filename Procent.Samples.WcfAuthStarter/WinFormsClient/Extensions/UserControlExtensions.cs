using System.Windows.Forms;
using System.Linq;

namespace Procent.Samples.WcfAuthStarter.Client.WinForms.Extensions
{
	public static class UserControlExtensions
	{
		public static void Clear(this UserControl _this)
		{
			foreach (var textBox in _this.Controls.OfType<TextBox>())
			{
				textBox.Clear();
			}
		}
	}
}
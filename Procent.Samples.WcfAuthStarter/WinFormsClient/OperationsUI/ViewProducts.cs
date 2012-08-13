using System.Windows.Forms;
using Procent.Samples.WcfAuthStarter.Client.WinForms.UserOperations;
using Procent.Samples.WcfAuthStarter.Common;
using Procent.Samples.WcfAuthStarter.ServiceContracts;

namespace Procent.Samples.WcfAuthStarter.Client.WinForms.OperationsUI
{
	[UserOperation("View products", AppRoles.ProductsViewer)]
	public partial class ViewProducts : UserControl
	{
		public ViewProducts()
		{
			InitializeComponent();
		}

		private void ViewProducts_Load(object sender, System.EventArgs e)
		{
			gridProducts.DataSource = ServiceProxyProvider<IProductsService>.Invoke(x => x.ViewAllProducts());
		}
	}
}

using System;
using System.Windows.Forms;
using Procent.Samples.WcfAuthStarter.Client.WinForms.UserOperations;
using Procent.Samples.WcfAuthStarter.Common;
using Procent.Samples.WcfAuthStarter.ServiceContracts;

namespace Procent.Samples.WcfAuthStarter.Client.WinForms.OperationsUI
{
	[UserOperation("Add new product", AppRoles.ProductsAdmin)]
	public partial class AddProduct : UserControl
	{
		public AddProduct()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			ServiceProxyProvider<IProductsService>.Invoke(x => x.AddProduct(tbName.Text, Convert.ToDouble(tbPrice.Text)));
		}
	}
}
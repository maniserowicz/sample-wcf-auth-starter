using System.ServiceModel;
using Procent.Samples.WcfAuthStarter.ServiceContracts.Data;

namespace Procent.Samples.WcfAuthStarter.ServiceContracts
{
	[ServiceContract]
	public interface IProductsService
	{
		[OperationContract]
		void AddProduct(string name, double price);

		[OperationContract]
		ProductDto[] ViewAllProducts();
	}
}
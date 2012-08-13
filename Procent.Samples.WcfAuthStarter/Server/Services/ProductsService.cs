using System;
using System.Security.Permissions;
using Procent.Samples.WcfAuthStarter.Common;
using Procent.Samples.WcfAuthStarter.Server.DataAccess;
using Procent.Samples.WcfAuthStarter.Server.Entities;
using System.Linq;
using Procent.Samples.WcfAuthStarter.ServiceContracts;
using Procent.Samples.WcfAuthStarter.ServiceContracts.Data;

namespace Procent.Samples.WcfAuthStarter.Server.Services
{
	public class ProductsService : IProductsService
	{
		[PrincipalPermission(SecurityAction.Demand, Role = AppRoles.ProductsAdmin)]
		public void AddProduct(string name, double price)
		{
			// DEMO CODE
			// should be created by a ProductFactory of some kind
			Product product = new Product
								{
									Id = Guid.NewGuid(),
									Name = name,
									Price = price,
									DateAdded = DateTime.UtcNow,
								};

			SampleDataAccessForDemoPurposesOnly.Products.AddProduct(product);
		}

		public ProductDto[] ViewAllProducts()
		{
			// DEMO CODE
			// AutoMapper would be used in real application
			return SampleDataAccessForDemoPurposesOnly.Products.GetAllProduct()
				.Select(x => new ProductDto { Id = x.Id, Name = x.Name, Price = x.Price, DateAdded = x.DateAdded })
				.ToArray();
		}
	}
}
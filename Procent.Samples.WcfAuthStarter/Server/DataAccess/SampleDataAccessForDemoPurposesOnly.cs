using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Procent.Samples.WcfAuthStarter.Common;
using Procent.Samples.WcfAuthStarter.Server.Entities;
using System.Linq;

namespace Procent.Samples.WcfAuthStarter.Server.DataAccess
{
	public static class SampleDataAccessForDemoPurposesOnly
	{
		public static class Products
		{
			private static readonly SynchronizedCollection<Product> _products =
				new SynchronizedCollection<Product>
					{
						new Product()
							{
								Id = Guid.NewGuid(),
								Name = "keyboard",
								Price = 87.3,
								DateAdded =
									new DateTime(2006, 6, 6, 18, 23, 54)
							},
						new Product()
							{
								Id = Guid.NewGuid(),
								Name = "blank dvd",
								Price = 2.98,
								DateAdded = new DateTime(2009, 8, 2)
							},
					};

			public static ICollection<Product> GetAllProduct()
			{
				return new ReadOnlyCollection<Product>(_products);
			}

			public static void AddProduct(Product newProduct)
			{
				_products.Add(newProduct);
			}
		}

		

		public static class Users
		{
			private static readonly SynchronizedCollection<User> _users =
				new SynchronizedCollection<User>
					{
						new User()
							{
								Id = 1,
								UserName = "KermitFrog",
								Password = "LovesPiggyPig",
							},
						new User()
							{
								Id = 2,
								UserName = "CarmenElectra",
								Password = "ElectrifyMe",
							},
					};

			public static User GetByUserName(string userName)
			{
				return _users.SingleOrDefault(x => x.UserName == userName);
			}

			public static string[] GetRolesForUser(int userId)
			{
				if (userId == 1)
					return new[] { AppRoles.ProductsViewer, AppRoles.ProductsAdmin, AppRoles.UsersAdmin };
				if (userId == 2)
					return new[] { AppRoles.ProductsViewer };

				return new string[0];
			}
		}
	}
}
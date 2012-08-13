using System;

namespace Procent.Samples.WcfAuthStarter.Server.Entities
{
	public class Product
	{
		public virtual Guid Id { get; set; }
		public virtual string Name { get; set; }
		public virtual double Price { get; set; }

		public virtual DateTime DateAdded { get; set; }
	}
}
using System;
using System.Runtime.Serialization;

namespace Procent.Samples.WcfAuthStarter.ServiceContracts.Data
{
	[DataContract]
	public class ProductDto
	{
		[DataMember]
		public virtual Guid Id { get; set; }
		[DataMember]
		public virtual string Name { get; set; }
		[DataMember]
		public virtual DateTime DateAdded { get; set; }
		[DataMember]
		public virtual double Price { get; set; }
	}
}
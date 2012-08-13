using System.ServiceModel;

namespace Procent.Samples.WcfAuthStarter.ServiceContracts
{
	[ServiceContract]
	public interface ISecurityService
	{
		[OperationContract]
		string[] GetRoles();
	}
}
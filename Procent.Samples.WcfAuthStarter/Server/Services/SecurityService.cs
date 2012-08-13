using Procent.Samples.WcfAuthStarter.Common.Security;
using System.Linq;
using Procent.Samples.WcfAuthStarter.ServiceContracts;

namespace Procent.Samples.WcfAuthStarter.Server.Services
{
	public class SecurityService : ISecurityService
	{
		public string[] GetRoles()
		{
			return ProcentPrincipal.Current.Roles.ToArray();
		}
	}
}
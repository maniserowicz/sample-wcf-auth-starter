using System.Collections.ObjectModel;
using System.Security.Principal;
using System.Threading;

namespace Procent.Samples.WcfAuthStarter.Common.Security
{
	public class ProcentPrincipal : GenericPrincipal
	{
		public readonly ReadOnlyCollection<string> Roles;

		public ProcentPrincipal(ProcentIdentity identity, string[] roles)
			: base(identity, roles)
		{
			Roles = new ReadOnlyCollection<string>(roles ?? new string[0]);
		}

		public static ProcentPrincipal Current
		{
			get
			{
				return Thread.CurrentPrincipal as ProcentPrincipal;
			}
		}
	}
}
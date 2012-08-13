using System.Security.Principal;
using System.Threading;

namespace Procent.Samples.WcfAuthStarter.Common.Security
{
	public class ProcentIdentity : GenericIdentity
	{
		public int Id;

		public ProcentIdentity(int id, string name)
			: base(name)
		{
			Id = id;
		}

		public static ProcentIdentity Current
		{
			get
			{
				return Thread.CurrentPrincipal.Identity as ProcentIdentity;
			}
		}
	}
}
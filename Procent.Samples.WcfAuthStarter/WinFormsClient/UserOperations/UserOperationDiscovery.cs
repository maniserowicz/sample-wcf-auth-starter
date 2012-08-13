using System;
using System.Collections.Generic;
using System.Linq;

namespace Procent.Samples.WcfAuthStarter.Client.WinForms.UserOperations
{
	public static class UserOperationDiscovery
	{
		public static Dictionary<Type, UserOperationAttribute> Perform()
		{
			var actions = from type in AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
			              let actionAttribute = type.GetCustomAttributes(typeof(UserOperationAttribute), false)
			              	.Cast<UserOperationAttribute>().SingleOrDefault()
			              where actionAttribute != null && actionAttribute.IsSatisfied
			              select new { type, attr = actionAttribute };

			return actions.ToDictionary(x => x.type, x => x.attr);
		}
	}
}
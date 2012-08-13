using System;
using System.Linq;
using System.Threading;

namespace Procent.Samples.WcfAuthStarter.Client.WinForms.UserOperations
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
	public sealed class UserOperationAttribute : Attribute
	{
		private readonly string[] _requiredPrivileges;
		public readonly string DisplayName;

		public UserOperationAttribute(string displayName, params string[] requiredPrivileges)
		{
			_requiredPrivileges = requiredPrivileges;
			DisplayName = displayName;
		}

		public bool IsSatisfied
		{
			get
			{
				// current user has all required privileges
				return _requiredPrivileges.All(Thread.CurrentPrincipal.IsInRole);
			}
		}
	}
}
using System;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.IdentityModel.Policy;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Principal;
using Procent.Samples.WcfAuthStarter.Common.Security;
using Procent.Samples.WcfAuthStarter.Server.DataAccess;
using Procent.Samples.WcfAuthStarter.Server.Entities;

namespace Procent.Samples.WcfAuthStarter.Server
{
	public class ServerSecurity : UserNamePasswordValidator, IAuthorizationPolicy
	{
		#region Implementation of UserNamePasswordValidator

		public override void Validate(string userName, string password)
		{
				User user = SampleDataAccessForDemoPurposesOnly.Users.GetByUserName(userName);

				if (user == null || user.Password != password)
					throw new SecurityTokenValidationException();
		}

		#endregion

		#region Implementation of IAuthorizationPolicy

		private Guid _authPolicyId = Guid.NewGuid();
		public string Id
		{
			get { return _authPolicyId.ToString(); }
		}

		public bool Evaluate(EvaluationContext evaluationContext, ref object state)
		{
			IIdentity identity = ((IList<IIdentity>)evaluationContext.Properties["Identities"]).Single();

			int userId = SampleDataAccessForDemoPurposesOnly.Users.GetByUserName(identity.Name).Id;

			var customIdentity = new ProcentIdentity(userId, identity.Name);
			string[] roles = SampleDataAccessForDemoPurposesOnly.Users.GetRolesForUser(userId);
			var customPrincipal = new ProcentPrincipal(customIdentity, roles);
			evaluationContext.Properties["PrimaryIdentity"] = customIdentity;
			evaluationContext.Properties["Principal"] = customPrincipal;

			return true;
		}

		public ClaimSet Issuer
		{
			get { return ClaimSet.System; }
		}

		#endregion
	}
}
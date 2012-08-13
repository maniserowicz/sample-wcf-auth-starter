using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Policy;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using Procent.Samples.WcfAuthStarter.Server.ErrorHandling;
using Procent.Samples.WcfAuthStarter.Server.Services;
using Procent.Samples.WcfAuthStarter.ServiceContracts;

namespace Procent.Samples.WcfAuthStarter.Server
{
	class StartServer
	{
		const string baseUri = "net.tcp://localhost:28736/";

		static readonly ServerSecurity _serverSecurity = new ServerSecurity();


		static void Main()
		{
			List<ServiceHost> hosts = new List<ServiceHost>
			                          	{
			                          		OpenHost<ISecurityService, SecurityService>("Security"),
			                          		OpenHost<IProductsService, ProductsService>("Products"),
			                          	};


			Console.WriteLine("Server ready. Press ENTER to close.");
			Console.ReadLine();

			foreach (IDisposable host in hosts)
			{
				host.Dispose();
			}

			Console.WriteLine("Server closed. Press any key to continue...");
			Console.ReadKey();
		}

		private static ServiceHost OpenHost<TContract, TImplementation>(string address) where TImplementation : TContract
		{
			ServiceHost host = new ServiceHost(typeof(TImplementation), new Uri(baseUri));

			// transfer security mode that enables username/password authentication
			NetTcpBinding tcpBinding = new NetTcpBinding(SecurityMode.Message);

			// client authentication configuration
			tcpBinding.Security.Message.ClientCredentialType = MessageCredentialType.UserName;
			// use custom logic to verify username/password (not MembershipProvider)
			host.Credentials.UserNameAuthentication.UserNamePasswordValidationMode = UserNamePasswordValidationMode.Custom;
			host.Credentials.UserNameAuthentication.CustomUserNamePasswordValidator = _serverSecurity;

			// client authorization configuration
			host.Authorization.PrincipalPermissionMode = PrincipalPermissionMode.Custom;
			// adding AuthorizationPolicy allows to set custom IPrincipal/IIdentity implementations for the Operation
			host.Authorization.ExternalAuthorizationPolicies = new ReadOnlyCollection<IAuthorizationPolicy>(new[] { _serverSecurity });
			
			// server identity verification by X.509 certificate (required by Message transfer security)
			using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Procent.Samples.WcfAuthStarter.Server.misc.WcfAuthSampleKey.pfx"))
			{
				byte[] bytes = new byte[stream.Length];
				stream.Read(bytes, 0, bytes.Length);
				host.Credentials.ServiceCertificate.Certificate = new X509Certificate2(bytes, string.Empty);
			}

			host.AddServiceEndpoint(typeof(TContract), tcpBinding, address);

			// add behavior that handles exceptions: logs and converts to faults
			host.Description.Behaviors.Add(new ErrorHandlingBehavior());

			host.Open();

			Console.WriteLine("Opened service {0} implemented by {1} under address	{2}", typeof(TContract).Name, typeof(TImplementation).Name, baseUri + address);

			return host;
		}
	}
}
using System;
using System.ServiceModel;

namespace Procent.Samples.WcfAuthStarter.Client.Core
{
	public class ServiceProxy<T> : ClientBase<T>, IDisposable where T : class
	{
		// empty ctor for default config if only one available
		public ServiceProxy()
		{
		}

		// ctor with config name; other ctors not available to enable ChannelFactory caching
		public ServiceProxy(string endpointConfigurationName)
			: base(endpointConfigurationName)
		{
		}

		public T GetChannel()
		{
			return base.Channel;
		}

		public void Dispose()
		{
			try
			{
				if (base.Channel != null)
				{
					if (base.State != CommunicationState.Faulted)
					{
						base.Close();
					}
					else
					{
						base.Abort();
					}
				}
			}
			catch (CommunicationException)
			{
				base.Abort();
			}
			catch (TimeoutException)
			{
				base.Abort();
			}
			catch (Exception)
			{
				base.Abort();
				throw;
			}
		}
	}
}
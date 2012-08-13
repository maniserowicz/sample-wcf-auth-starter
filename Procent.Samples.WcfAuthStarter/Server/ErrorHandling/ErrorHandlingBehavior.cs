using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Procent.Samples.WcfAuthStarter.Server.ErrorHandling
{
	public class ErrorHandlingBehavior : IServiceBehavior, IErrorHandler
	{
		public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
		{
			var faultExc = new FaultException(error.Message);
			var messageFault = faultExc.CreateMessageFault();
			fault = Message.CreateMessage(version, messageFault, faultExc.Action);
		}

		public bool HandleError(Exception error)
		{
			EventLog.WriteEntry("ProcentSampleWcfApp", error.ToString(), EventLogEntryType.Error);
			return false;
		}

		public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
		{
		}

		public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
		{
		}

		public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
		{
			foreach (ChannelDispatcher channelDispatcher in serviceHostBase.ChannelDispatchers)
			{
				channelDispatcher.ErrorHandlers.Add(this);
			}
		}
	}
}
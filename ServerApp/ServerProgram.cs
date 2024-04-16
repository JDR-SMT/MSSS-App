// 3. Host and run the service in a console application.

using System;
using System.ServiceModel;

namespace ServerApp
{
	internal class ServerProgram
	{
		static void Main(string[] args)
		{
			// set base address
			string address = "net.pipe://localhost/pipeformulas";

			// create a ServiceHost instance
			ServiceHost serviceHost = new ServiceHost(typeof(AstroServer));
			// create NetNamedPipeBinding instance
			NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
			// add service endpoint
			serviceHost.AddServiceEndpoint(typeof(IAstroContract), binding, address);
			// open ServiceHost to start service
			serviceHost.Open();

			Console.WriteLine("ServiceHost is running. Press <Enter> to Exit");
			Console.ReadLine();

			// close ServiceHost to stop service
			serviceHost.Close();
		}
	}
}

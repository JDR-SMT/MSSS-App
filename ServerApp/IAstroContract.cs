// 1. A ServiceContract specifies which OperationContracts the service supports.

using System.ServiceModel;

namespace ServerApp
{
	[ServiceContract]
	internal interface IAstroContract
	{
		[OperationContract]
		double StarVelocity(double observed, double rest);

		[OperationContract]
		double StarDistance(double parallax);

		[OperationContract]
		double Kelvin(double celsius);

		[OperationContract]
		double EventHorizon(double mass);
	}
}

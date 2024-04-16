using System.ServiceModel;

namespace ClientApp
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

// 2. Implement the IAstroContract interface.

using AstroMath;
using System.ServiceModel;

namespace ServerApp
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
	internal class AstroServer : IAstroContract
	{
		Formulas formulas = new Formulas();

		public double StarVelocity(double observed, double rest)
		{
			return formulas.StarVelocity(observed, rest);
		}

		public double StarDistance(double parallax)
		{
			return formulas.StarDistance(parallax);
		}

		public double Kelvin(double celsius)
		{
			return formulas.Kelvin(celsius);
		}

		public double EventHorizon(double mass)
		{
			return formulas.EventHorizon(mass);
		}
	}
}

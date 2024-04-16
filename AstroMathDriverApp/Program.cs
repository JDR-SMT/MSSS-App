using AstroMath;
using System;

namespace AstroMathDriverApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Formulas formulas = new Formulas();
			Console.WriteLine("AstroMath.dll Driver Application");

			Console.WriteLine("\nCalculate the star velocity when the observed wavelength is 500.1 nm and the wavelength at rest is 500.0 nm: ");
			Console.WriteLine($"{Math.Round(formulas.StarVelocity(500.1, 500.0), 0)} m/s.");

			Console.WriteLine("\nCalculate the star distance when the parallax angle is 0.547 arcsec: ");
			Console.WriteLine($"{Math.Round(formulas.StarDistance(0.547), 2)} pc.");

			Console.WriteLine("\nCalculate Kelvin when the temperature is 27 degrees Celsius: ");
			Console.WriteLine($"{formulas.Kelvin(27)} K.");

			Console.WriteLine("\nCalculate the event horizon when the mass of a black hole is 8.2 x 10^36 kg: ");
			Console.WriteLine($"{formulas.EventHorizon(8.2 * Math.Pow(10, 36)):E1} m.");

			Console.ReadLine();
		}
	}
}

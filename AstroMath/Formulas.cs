using System;

namespace AstroMath
{
	/// <summary>
	/// Contains formulas to calculate the velocity of a star, the distance of a star, 
	/// the Kelvin temperature from Celsius, and the event horizon of a black hole.
	/// </summary>
	public class Formulas
	{
		/// <summary>
		/// The speed of light in metres per second.
		/// </summary>
		public double light = 2.99792458 * Math.Pow(10, 8);

		/// <summary>
		/// The velocity of stars is determined by using the doppler effect. The doppler effect is produced by the motion 
		/// of a light source causing spectral lines to shift. If the star is moving away, the wavelengths will appear 
		/// stretched out and the wavelength shift will be a positive number, resulting in a redshift where the spectral 
		/// lines appear to shift towards the red end of spectrum. If the star is moving closer, the wavelengths will 
		/// appear compressed and the wavelength shift will be a negative number, resulting in a blueshift where the 
		/// spectral lines appear to shift towards the blue end of spectrum. The wavelength shift is the observed 
		/// wavelength minus the wavelength at rest. The star velocity is the wavelength shift divided by the wavelength 
		/// at rest multiplied by the speed of light. If the observed wavelength is 500.1 nanometres and the wavelength 
		/// at rest is 500.0 nanometres, the star velocity will be approximately 60,000 metres per second.
		/// </summary>
		/// <param name="observed">The observed wavelength in nanometres.</param>
		/// <param name="rest">The wavelength at rest in nanometres.</param>
		/// <returns>The star velocity in metres per second.</returns>
		public double StarVelocity(double observed, double rest)
		{
			double shift = observed - rest;
			return light * (shift / rest);
		}

		/// <summary>
		/// The distance of stars is determined by using trigonometric parallax. A parsec is the distance of a star that has 
		/// a parallax of one arc second using a baseline of 1 astronomical unit. 1 parsec equates to 206,265 astronomical 
		/// units. Angle in arc seconds is 206,265 multiplied by baseline divided by distance, with baseline and distance in 
		/// the same length units. Parallax angle in arc seconds is baseline in astronomical units divided by distance in 
		/// parsecs. Star distance in parsecs is baseline divided by parallax angle. Baseline = 1 for measurements from the 
		/// Earth. If the parallax angle is 0.547 arc seconds, the distance of the star is 1.83 parsecs.
		/// </summary>
		/// <param name="parallax">The parallax angle in arc seconds.</param>
		/// <returns>The star distance in parsecs.</returns>
		public double StarDistance(double parallax)
		{
			return 1 / parallax;
		}

		/// <summary>
		/// Converts the temperature from Celsius to Kelvin. Kelvin is the base unit of thermodynamic 
		/// temperature measurement. A temperature of 0 Kelvin represents absolute zero. Kelvin is 
		/// Celsius plus 273. A temperature of 27 degrees Celsius is equal to 300 Kelvin.
		/// </summary>
		/// <param name="celsius">The temperature in Celsius.</param>
		/// <returns>The temperature in Kelvin.</returns>
		public double Kelvin(double celsius)
		{
			return celsius + 273;
		}

		/// <summary>
		/// A black hole occurs when a the mass of a star is so large that its internal gravity compresses all materials of 
		/// the star. The event horizon is the point or a collection of points in space that divides two areas that cannot 
		/// communicate with each other. Escape velocity is the speed required to move away from the gravitational pull of 
		/// an object. With a black hole, the event horizon point is where the escape velocity and the speed of light is the 
		/// same. The event horizon of a black hole is also known as the Schwarzschild radius. The Schwarzschild radius is 
		/// 2 multiplied by the gravitational constant in kilograms multiplied by the black hole mass in kilograms divided 
		/// by the square of the speed of light in metres per second. If the black hole mass is 8.2 x 10^36 kilograms, the 
		/// Schwarzschild radius is 1.2 x 10^10 metres.
		/// </summary>
		/// <param name="mass">The mass of a black hole in kilograms.</param>
		/// <returns>The Schwarzschild radius in metres.</returns>
		public double EventHorizon(double mass)
		{
			double gravity = 6.674 * Math.Pow(10, -11);
			return (2 * gravity * mass) / Math.Pow(light, 2);
		}
	}
}

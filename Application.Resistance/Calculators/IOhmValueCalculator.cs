namespace Application.Resistance.Calculators
{
	public interface IOhmValueCalculator
	{
		///

		/// Calculates the Ohm value of a resistor based on the band colors.

		///

		/// The color of the first figure of component value band.

		/// The color of the second significant figure band.

		/// The color of the decimal multiplier band.

		/// The color of the tolerance value band.

		int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);
	}
}
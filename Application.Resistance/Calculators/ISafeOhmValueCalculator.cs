namespace Application.Resistance.Calculators
{
	public interface ISafeOhmValueCalculator
	{
		/// <summary>
		/// Calculates the Ohm value of a resistor based on the band colors.
		/// </summary>
		/// <param name="bandAColor">The color of the first figure of component value band.</param>
		/// <param name="bandBColor">The color of the second significant figure band.</param>
		/// <param name="bandCColor">The color of the decimal multiplier band.</param>
		/// <returns>The value.</returns>
		decimal CalculateOhmValue(ResistorColor bandAColor, ResistorColor bandBColor, ResistorColor bandCColor);

		// decimal CalculateOhmValueMin(ResistorColor bandAColor, ResistorColor bandBColor, ResistorColor bandCColor, ResistorColor bandDColor);

		// decimal CalculateOhmValueMax(ResistorColor bandAColor, ResistorColor bandBColor, ResistorColor bandCColor, ResistorColor bandDColor);
	}
}
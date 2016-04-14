namespace Application.Resistance.Calculators
{
	using System;

	public class OhmValueCalculator : IOhmValueCalculator, ISafeOhmValueCalculator, IDecimalOhmValueCalculator
	{
		/// <summary>
		/// Calculates the Ohm value of a resistor based on the band colors.
		/// A decimal return type is used to support fractional ohm resisters gold or silver in band C
		/// </summary>
		/// <param name="bandAColor">The color of the first figure of component value band.</param>
		/// <param name="bandBColor">The color of the second significant figure band.</param>
		/// <param name="bandCColor">The color of the decimal multiplier band.</param>
		/// <returns>The value.</returns>
		public decimal CalculateOhmValue(ResistorColor bandAColor, ResistorColor bandBColor, ResistorColor bandCColor)
		{
			if (bandAColor.BandA == null || bandBColor.BandB == null || bandCColor.Multiplier == null)
			{
				throw new ApplicationException("One or more color values were invalid for the given usage.");
			}

			decimal? resisterValue = (bandAColor.BandA + bandBColor.BandB) * bandCColor.Multiplier;

			return resisterValue.Value;
		}

		/// <summary>
		/// Calculates the Ohm value of a resistor based on the band colors.
		/// this method will not be able to accurately represent the values of resistors with silver or gold in the multiplier band.
		/// </summary>
		/// <param name="bandAColor">The color of the first figure of component value band.</param>
		/// <param name="bandBColor">The color of the second significant figure band.</param>
		/// <param name="bandCColor">The color of the decimal multiplier band.</param>
		/// <returns>The value.</returns>
		public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
		{
			return (int)((IDecimalOhmValueCalculator)this).CalculateOhmValue(bandAColor, bandBColor, bandCColor);
		}

		/// <summary>
		/// Calculates the Ohm value of a resistor based on the band colors.
		/// </summary>
		/// <param name="bandAColor">The color of the first figure of component value band.</param>
		/// <param name="bandBColor">The color of the second significant figure band.</param>
		/// <param name="bandCColor">The color of the decimal multiplier band.</param>
		/// <returns>The value.</returns>
		decimal IDecimalOhmValueCalculator.CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor)
		{
			var bandA = ResistorColor.FromDisplayName<ResistorColor>(bandAColor.ToLowerInvariant());
			var bandB = ResistorColor.FromDisplayName<ResistorColor>(bandBColor.ToLowerInvariant());
			var bandC = ResistorColor.FromDisplayName<ResistorColor>(bandCColor.ToLowerInvariant());

			return this.CalculateOhmValue(bandA, bandB, bandC);
		}
	}
}
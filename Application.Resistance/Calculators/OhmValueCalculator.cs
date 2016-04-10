namespace Application.Resistance.Calculators
{
	using System;

	public class OhmValueCalculator : IOhmValueCalculator, ISafeOhmValueCalculator, IDecimalOhmValueCalculator
	{
		// a decimal return type is used to support fractional ohm resisters gold or silver in band C
		public decimal CalculateOhmValue(ResistorColor bandAColor, ResistorColor bandBColor, ResistorColor bandCColor)
		{
			// I didn't have time to set up a more formal guard syntax this should be revisited
			if (bandAColor.BandA == null || bandBColor.BandB == null || bandCColor.Multiplier == null)
			{
				throw new ArgumentException("One or more color values were invalid for the given usage.");
			}

			decimal? resisterValue = (bandAColor.BandA + bandBColor.BandB) * bandCColor.Multiplier;

			return resisterValue.Value;
		}

		// this method will not be able to accurately represent the values of resistors with silver or gold in the multiplier band.
		public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
		{
			return (int)((IDecimalOhmValueCalculator)this).CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);
		}

		decimal IDecimalOhmValueCalculator.CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
		{
			var bandA = ResistorColor.FromDisplayName<ResistorColor>(bandAColor.ToLowerInvariant());
			var bandB = ResistorColor.FromDisplayName<ResistorColor>(bandBColor.ToLowerInvariant());
			var bandC = ResistorColor.FromDisplayName<ResistorColor>(bandCColor.ToLowerInvariant());
			//var bandD = ResistorColor.FromDisplayName<ResistorColor>(bandDColor.ToLowerInvariant());

			return this.CalculateOhmValue(bandA, bandB, bandC);
		}
	}
}
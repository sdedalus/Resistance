using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Resistance.Calculators
{
	public class OhmValueCalculator : IOhmValueCalculator, ISafeOhmValueCalculator
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


		public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
		{
			var bandA = ResistorColor.FromDisplayName<ResistorColor>(bandAColor);
			var bandB = ResistorColor.FromDisplayName<ResistorColor>(bandBColor);
			var bandC = ResistorColor.FromDisplayName<ResistorColor>(bandCColor);
			var bandD = ResistorColor.FromDisplayName<ResistorColor>(bandDColor);

			return (int)this.CalculateOhmValue(bandA, bandB, bandC);
		}								  
	}									  
}										  

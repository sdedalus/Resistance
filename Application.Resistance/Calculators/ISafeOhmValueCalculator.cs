using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Resistance.Calculators
{
	public interface ISafeOhmValueCalculator
	{

		///

		/// Calculates the Ohm value of a resistor based on the band colors.

		///
		decimal CalculateOhmValue(ResistorColor bandAColor, ResistorColor bandBColor, ResistorColor bandCColor);

		// decimal CalculateOhmValueMin(ResistorColor bandAColor, ResistorColor bandBColor, ResistorColor bandCColor, ResistorColor bandDColor);

		// decimal CalculateOhmValueMax(ResistorColor bandAColor, ResistorColor bandBColor, ResistorColor bandCColor, ResistorColor bandDColor);
	}
}

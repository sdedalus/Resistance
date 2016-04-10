namespace Application.Resistance.Testing
{
	using Calculators;
	using NUnit.Framework;
	using Resistance;

	public class ResistanceCalculatorShould
	{
		[TestCase(1, 0, 0, 1, 10)]
		[TestCase(1, 0, 1, 1, 100)]
		[TestCase(1, 0, 2, 1, 1000)]
		[TestCase(1, 0, 3, 1, 10000)]
		[TestCase(1, 1, 0, 1, 11)]
		[TestCase(1, 1, 1, 1, 110)]
		[TestCase(1, 1, 2, 1, 1100)]
		[TestCase(1, 1, 3, 1, 11000)]
		[TestCase(9, 0, 0, 1, 90)]
		[TestCase(9, 0, 1, 1, 900)]
		[TestCase(9, 0, 2, 1, 9000)]
		[TestCase(9, 0, 3, 1, 90000)]
		[TestCase(9, 1, 0, 1, 91)]
		[TestCase(9, 1, 1, 1, 910)]
		[TestCase(9, 1, 2, 1, 9100)]
		[TestCase(9, 1, 3, 1, 91000)]
		[TestCase(1, 0, -1, 1, 1)]
		[TestCase(1, 0, -2, 1, .1)]
		public void CalculateResistanceForValidColorChoices(int bandA, int bandB, int bandC, int bandD, decimal expected)
		{
			var colorA = ResistorColor.FromValue<ResistorColor>(bandA);
			var colorB = ResistorColor.FromValue<ResistorColor>(bandB);
			var colorC = ResistorColor.FromValue<ResistorColor>(bandC);
			var colorD = ResistorColor.FromValue<ResistorColor>(bandD);
			var calculator = new OhmValueCalculator();
			// we are testing the ISafeOhmValueCalculator here.
			Assert.AreEqual(expected, calculator.CalculateOhmValue(colorA, colorB, colorC));
		}

		[TestCase(1, 0, 0, 1, 10)]
		[TestCase(1, 0, 1, 1, 100)]
		[TestCase(1, 0, 2, 1, 1000)]
		[TestCase(1, 0, 3, 1, 10000)]
		[TestCase(1, 1, 0, 1, 11)]
		[TestCase(1, 1, 1, 1, 110)]
		[TestCase(1, 1, 2, 1, 1100)]
		[TestCase(1, 1, 3, 1, 11000)]
		[TestCase(9, 0, 0, 1, 90)]
		[TestCase(9, 0, 1, 1, 900)]
		[TestCase(9, 0, 2, 1, 9000)]
		[TestCase(9, 0, 3, 1, 90000)]
		[TestCase(9, 1, 0, 1, 91)]
		[TestCase(9, 1, 1, 1, 910)]
		[TestCase(9, 1, 2, 1, 9100)]
		[TestCase(9, 1, 3, 1, 91000)]
		[TestCase(1, 0, -1, 1, 1)]
		[TestCase(1, 0, -2, 1, 0)] // the fractional component of this one can't be represented as a integer
		public void CalculateResistanceForValidColorChoicesUsingIntegerReturnTypeOverload(int bandA, int bandB, int bandC, int bandD, int expected)
		{
			var colorA = ResistorColor.FromValue<ResistorColor>(bandA);
			var colorB = ResistorColor.FromValue<ResistorColor>(bandB);
			var colorC = ResistorColor.FromValue<ResistorColor>(bandC);
			var colorD = ResistorColor.FromValue<ResistorColor>(bandD);
			var calculator = new OhmValueCalculator();
			// we are testing IOhmValueCalculator here
			Assert.AreEqual(expected, calculator.CalculateOhmValue(colorA.DisplayName, colorB.DisplayName, colorC.DisplayName, colorD.DisplayName));
		}

		[TestCase(1, 0, 0, 1, 10)]
		[TestCase(1, 0, 1, 1, 100)]
		[TestCase(1, 0, 2, 1, 1000)]
		[TestCase(1, 0, 3, 1, 10000)]
		[TestCase(1, 1, 0, 1, 11)]
		[TestCase(1, 1, 1, 1, 110)]
		[TestCase(1, 1, 2, 1, 1100)]
		[TestCase(1, 1, 3, 1, 11000)]
		[TestCase(9, 0, 0, 1, 90)]
		[TestCase(9, 0, 1, 1, 900)]
		[TestCase(9, 0, 2, 1, 9000)]
		[TestCase(9, 0, 3, 1, 90000)]
		[TestCase(9, 1, 0, 1, 91)]
		[TestCase(9, 1, 1, 1, 910)]
		[TestCase(9, 1, 2, 1, 9100)]
		[TestCase(9, 1, 3, 1, 91000)]
		[TestCase(1, 0, -1, 1, 1)]
		[TestCase(1, 0, -2, 1, .1)]
		public void CalculateResistanceForValidColorChoicesUsingDecimalReturnTypeOverload(int bandA, int bandB, int bandC, int bandD, decimal expected)
		{
			var colorA = ResistorColor.FromValue<ResistorColor>(bandA);
			var colorB = ResistorColor.FromValue<ResistorColor>(bandB);
			var colorC = ResistorColor.FromValue<ResistorColor>(bandC);
			var colorD = ResistorColor.FromValue<ResistorColor>(bandD);
			var calculator = new OhmValueCalculator();
			// we are testing the ISafeOhmValueCalculator here.
			Assert.AreEqual(expected, ((IDecimalOhmValueCalculator)calculator).CalculateOhmValue(colorA.DisplayName, colorB.DisplayName, colorC.DisplayName, colorD.DisplayName));
		}
	}
}
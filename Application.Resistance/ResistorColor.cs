namespace Application.Resistance
{
	using ResistanceCommon.Enumeration;
	using System;

	public class ResistorColor : Enumeration
	{
		public static readonly ResistorColor Black = new ResistorColor(0, "black", 0, 0, 1);
		public static readonly ResistorColor Brown = new ResistorColor(1, "brown", 10, 1, 10, 0.01M);
		public static readonly ResistorColor Red = new ResistorColor(2, "red", 20, 2, 100, 0.02M);
		public static readonly ResistorColor Orange = new ResistorColor(3, "orange", 30, 3, 1000);
		public static readonly ResistorColor Yellow = new ResistorColor(4, "yellow", 40, 4, 10000);
		public static readonly ResistorColor Green = new ResistorColor(5, "green", 50, 5, 100000, 0.005M);
		public static readonly ResistorColor Blue = new ResistorColor(6, "blue", 60, 6, 1000000);
		public static readonly ResistorColor Violet = new ResistorColor(7, "violet", 70, 7, 10000000);
		public static readonly ResistorColor Gray = new ResistorColor(8, "gray", 80, 8, 100000000);
		public static readonly ResistorColor White = new ResistorColor(9, "white", 90, 9, 1000000000);
		public static readonly ResistorColor Gold = new ResistorColor(10, "gold", null, null, 0.1M, 0.05M);
		public static readonly ResistorColor Silver = new ResistorColor(11, "silver", null, null, 0.01M, 0.1M);
		public static readonly ResistorColor None = new ResistorColor(12, "none", 0, 0, 1, 0.2M);

		public decimal? BandA { get; private set; }
		public decimal? BandB { get; private set; }
		public decimal? Multiplier { get; private set; }
		public decimal? Tolerance { get; private set; }

		public ResistorColor()
		{
		}

		public ResistorColor(int value, string color, decimal? bandA, decimal? bandB, decimal? multiplier, Decimal? tolerance = null)
			: base(value, color)
		{
			this.BandA = bandA;
			this.BandB = bandB;
			this.Multiplier = multiplier;
			this.Tolerance = tolerance;
		}
	}
}
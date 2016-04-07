using ResistanceCommon.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Resistance
{
	public class ResistorColor : Enumeration
	{
		public static readonly ResistorColor Black =	new ResistorColor("black",	0,    	0,    	1);
		public static readonly ResistorColor Brown =	new ResistorColor("brown",	10,    	1,    	10, 0.01M);
		public static readonly ResistorColor Red =		new ResistorColor("red",	20,    	2,    	100, 0.02M);
		public static readonly ResistorColor Orange =	new ResistorColor("orange",	30,    	3,    	1000);
		public static readonly ResistorColor Yellow =	new ResistorColor("yellow",	40,    	4,    	10000);
		public static readonly ResistorColor Green =	new ResistorColor("green",	50,    	5,    	100000, 0.005M);
		public static readonly ResistorColor Blue =		new ResistorColor("blue",	60,    	6,    	1000000);
		public static readonly ResistorColor Violet =	new ResistorColor("violet",	70,    	7,    	10000000);
		public static readonly ResistorColor Gray =		new ResistorColor("gray",	80,    	8,		100000000);
		public static readonly ResistorColor White =	new ResistorColor("white",	90,    	9,		1000000000);
		public static readonly ResistorColor Gold =		new ResistorColor("gold",	null, 	null, 	0.1M, 0.05M);
		public static readonly ResistorColor Silver =	new ResistorColor("silver", null,   null,   0.01M, 0.1M);
		public static readonly ResistorColor None =		new ResistorColor("none",   0,		0,		1, 0.2M);

		public decimal? BandA { get; private set; }
		public decimal? BandB { get; private set; }
		public decimal? Multiplier { get; private set; }
		public decimal? Tolerance { get; private set; }

		public ResistorColor() { }
		public ResistorColor( string color, decimal? bandA, decimal? bandB, decimal? multiplier, Decimal? tolerance = null )
			: base((int)bandA, color)
		{
			this.BandA = bandA;
			this.BandB = bandB;
			this.Multiplier = multiplier;
			this.Tolerance = tolerance;
		}
	}
}

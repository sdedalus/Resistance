using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Resistance.DataTransferObjects
{
	public class ResistorResponseDTO
	{
		public string BandAColor { get; set; }
		public string BandBColor { get; set; }
		public string BandCColor { get; set; }

		public decimal Resistance { get; set; }

	}
}

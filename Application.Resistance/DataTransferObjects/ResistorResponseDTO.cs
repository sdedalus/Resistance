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
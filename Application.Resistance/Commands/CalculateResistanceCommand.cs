namespace Application.Resistance.Commands
{
	using ResistanceCommon.Command;

	public class CalculateResistanceCommand : ICommand<decimal>
	{
		public string BandA { get; set; }
		public string BandB { get; set; }
		public string BandC { get; set; }
	}
}
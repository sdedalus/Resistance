namespace Application.Resistance.Commands
{
	using Application.Resistance.Calculators;
	using Application.Resistance.Command;

	public class CalculateResistanceCommandHandler : ICommandHandler<CalculateResistanceCommand, decimal>
	{
		private IDecimalOhmValueCalculator ohmCalculator;

		public CalculateResistanceCommandHandler(IDecimalOhmValueCalculator ohmCalculator)
		{
			this.ohmCalculator = ohmCalculator;
		}

		public decimal Execute(CalculateResistanceCommand comand)
		{
			return ohmCalculator.CalculateOhmValue(comand.BandA, comand.BandB, comand.BandC, "none");
		}
	}
}
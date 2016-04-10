namespace Resistance.Host.Controllers
{
	using Application.Resistance.Command;
	using Application.Resistance.Commands;
	using Application.Resistance.DataTransferObjects;
	using System.Web.Http;

	public class ResistanceController : ApiController
	{
		private ICommandMediator mediator;

		public ResistanceController(CommandMediator mediator)
		{
			this.mediator = mediator;
		}

		public ResistorResponseDTO Get(string bandA, string bandB, string bandC)
		{
			var response = new ResistorResponseDTO()
			{
				BandAColor = bandA,
				BandBColor = bandB,
				BandCColor = bandC
			};

			var command = new CalculateResistanceCommand()
			{
				BandA = bandA,
				BandB = bandB,
				BandC = bandC
			};

			var returnValue = mediator.Invoke<CalculateResistanceCommand, decimal>(command);

			response.Resistance = returnValue;

			return response;
		}
	}
}
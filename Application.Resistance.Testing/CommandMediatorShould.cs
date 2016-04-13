namespace Application.Resistance.Testing
{
	using Calculators;
	using Commands;
	using Microsoft.Practices.Unity;
	using NUnit.Framework;
	using Resistance;
	using ResistanceCommon.Command;
	using ResistanceCommon.IOC;
	using Rhino;
	using Rhino.Mocks;

	public class CommandMediatorShould
	{
		[TestCase]
		public void ReturnValidValueGivenProperRegistrationAndValidArguments()
		{
			var ioc = new InversionOfControl();
			ResistanceCommon.IOC.Initializer.Initialize();
			var command = MockRepository.GenerateMock<CalculateResistanceCommand>();
			var handler = MockRepository.GenerateMock<CalculateResistanceCommandHandler>(new OhmValueCalculator());
			ioc.Container().RegisterInstance(command);

			command.BandA = "red";
			command.BandB = "red";
			command.BandC = "red";

			ioc.Container().RegisterInstance<ICommandHandler<CalculateResistanceCommand, decimal>>(handler);

			var mediator = new CommandMediator(ioc.Container());

			// I will need to find a better way to test this.
			Assert.AreEqual(2200, mediator.Invoke<CalculateResistanceCommand, decimal>(command));
		}
	}
}
namespace Application.Resistance
{
	using AutoMapper;
	using Calculators;
	using Command;
	using Commands;
	using Mapping;
	using Microsoft.Practices.Unity;
	using ResistanceCommon.IOC;

	public class Bootstrapper
	{
		private static IUnityContainer container;

		public Bootstrapper(InversionOfControl inversionOfControl)
		{
			Bootstrapper.container = inversionOfControl.Container();
		}

		public void Start()
		{
			Configure();
			ConfigureMap();
		}

		private void Configure()
		{
			// this could be done with convention based registration.
			container.RegisterType<ICommandHandler<CalculateResistanceCommand, decimal>, CalculateResistanceCommandHandler>(new ContainerControlledLifetimeManager());
			container.RegisterType<IDecimalOhmValueCalculator, OhmValueCalculator>(new ContainerControlledLifetimeManager());
		}

		private void ConfigureMap()
		{
			var config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<ConfigureAutomapper>();
			});
			container.RegisterInstance<IMapper>(config.CreateMapper());
		}
	}
}
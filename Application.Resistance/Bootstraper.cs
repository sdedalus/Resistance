namespace Application.Resistance
{
	using System;
	using Microsoft.Practices.Unity;
	using ResistanceCommon.IOC;
	using AutoMapper;
	using Mapping;
	public class Bootstrapper
	{
		private static IUnityContainer inversionOfControl;
		public Bootstrapper(InversionOfControl inversionOfControl)
		{
			Bootstrapper.inversionOfControl = inversionOfControl.Container();
		}
		public void Start()
		{
			Configure();
			ConfigureMap();
		}

		private void Configure()
		{

			
		}

		private void ConfigureMap()
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<ConfigureAutomapper>();
			});
			inversionOfControl.RegisterInstance<IMapper>(config.CreateMapper());
		}
	}
}

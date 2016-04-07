namespace Resistance.Host
{
	using System;
	using Microsoft.Practices.Unity;
	using ResistanceCommon.IOC;
	public class Bootstrapper
	{
		private static InversionOfControl inversionOfControl;
		public Bootstrapper(InversionOfControl inversionOfControl)
		{
			Bootstrapper.inversionOfControl = inversionOfControl;
		}
		public void Start()
		{
			Configure();
		}

		private static void Configure()
		{
			var appBootstrap = new Application.Resistance.Bootstrapper(inversionOfControl);
		}
	}
}

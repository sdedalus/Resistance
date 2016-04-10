namespace ResistanceCommon.IOC
{
	using Command;
	using Microsoft.Practices.Unity;

	public static class InversionOfControlImplementation
	{
		private static IUnityContainer container;

		public static IUnityContainer Container(this InversionOfControl ioc)
		{
			return container;
		}

		internal static void Initialize()
		{
			if (container == null)
			{
				// this particular anti pattern is limited to a single use
				container = new UnityContainer();
				container.RegisterInstance<IUnityContainer>(container);
				container.RegisterType<ICommandMediator, CommandMediator>(new ContainerControlledLifetimeManager());
			}
		}
	}
}
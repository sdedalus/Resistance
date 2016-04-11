namespace ResistanceCommon.IOC
{
	using Command;
	using Microsoft.Practices.Unity;

	public static class UnityInversionOfControlImplementation
	{
		private static IUnityContainer container;

		/// <summary>
		/// returns the specified IOC Container.
		/// </summary>
		/// <param name="ioc">The InversionOfControl object.</param>
		/// <returns>the IUnityContainer</returns>
		public static IUnityContainer Container(this InversionOfControl ioc)
		{
			return container;
		}

		/// <summary>
		/// Initializes this instance.
		/// </summary>
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
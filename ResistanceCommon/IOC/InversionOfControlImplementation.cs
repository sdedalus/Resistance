using Application.Resistance.Command;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistanceCommon.IOC
{
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

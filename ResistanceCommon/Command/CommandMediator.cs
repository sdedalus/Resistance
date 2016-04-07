using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Application.Resistance.Command
{
	public class CommandMediator : ICommandMediator
	{
		private IUnityContainer container;
		public CommandMediator(IUnityContainer container)
		{
			this.container = container;
		}

		public TReturn Invoke<TReturn>(ICommand<TReturn> command)
		{
			ICommandHandler<ICommand<TReturn>, TReturn> handler = container.Resolve<ICommandHandler<ICommand<TReturn>, TReturn>>();
			return handler.Execute(command);
		}
	}
}

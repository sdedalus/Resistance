namespace Application.Resistance.Command
{
	using Microsoft.Practices.Unity;

	public class CommandMediator : ICommandMediator
	{
		private IUnityContainer container;

		public CommandMediator(IUnityContainer container)
		{
			this.container = container;
		}

		public TReturn Invoke<TCommand, TReturn>(TCommand command) where TCommand : ICommand<TReturn>
		{
			ICommandHandler<TCommand, TReturn> handler = container.Resolve<ICommandHandler<TCommand, TReturn>>();
			return handler.Execute(command);
		}
	}
}
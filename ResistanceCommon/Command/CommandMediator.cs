namespace ResistanceCommon.Command
{
	using Microsoft.Practices.Unity;

	public class CommandMediator : ICommandMediator
	{
		/// <summary>
		/// The container
		/// </summary>
		private IUnityContainer container;

		/// <summary>
		/// Initializes a new instance of the <see cref="CommandMediator"/> class.
		/// </summary>
		/// <param name="container">The container.</param>
		public CommandMediator(IUnityContainer container)
		{
			this.container = container;
		}

		/// <summary>
		/// Invokes the specified command.
		/// </summary>
		/// <typeparam name="TCommand">The type of the command.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="command">The command.</param>
		/// <returns></returns>
		public TReturn Invoke<TCommand, TReturn>(TCommand command) where TCommand : ICommand<TReturn>
		{
			ICommandHandler<TCommand, TReturn> handler = container.Resolve<ICommandHandler<TCommand, TReturn>>();
			return handler.Execute(command);
		}
	}
}
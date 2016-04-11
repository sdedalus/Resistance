namespace ResistanceCommon.Command
{
	public interface ICommandMediator
	{
		/// <summary>
		/// Invokes the specified command.
		/// </summary>
		/// <typeparam name="TCommand">The type of the command.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="command">The command.</param>
		/// <returns></returns>
		TReturn Invoke<TCommand, TReturn>(TCommand command) where TCommand : ICommand<TReturn>;
	}
}
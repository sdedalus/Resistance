namespace ResistanceCommon.Command
{
	public interface ICommandHandler<Tcommand, out TReturn> where Tcommand : ICommand<TReturn>
	{
		/// <summary>
		/// Executes the specified command.
		/// </summary>
		/// <param name="comand">The command.</param>
		/// <returns></returns>
		TReturn Execute(Tcommand command);
	}
}
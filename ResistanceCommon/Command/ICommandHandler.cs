namespace Application.Resistance.Command
{
	public interface ICommandHandler<Tcommand, out TReturn> where Tcommand : ICommand<TReturn>
	{
		TReturn Execute(Tcommand comand);
	}
}
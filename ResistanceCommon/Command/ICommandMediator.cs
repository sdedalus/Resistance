namespace Application.Resistance.Command
{
	public interface ICommandMediator
	{
		TReturn Invoke<TReturn>(ICommand<TReturn> command);
	}
}
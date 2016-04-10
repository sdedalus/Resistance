﻿namespace Application.Resistance.Command
{
	public interface ICommandMediator
	{
		TReturn Invoke<TCommand, TReturn>(TCommand command) where TCommand : ICommand<TReturn>;
	}
}
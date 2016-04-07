using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Resistance.Command
{
	public interface ICommandHandler<Tcommand, out TReturn> where Tcommand: ICommand<TReturn> 
	{
		TReturn Execute(Tcommand comand);
	}
}

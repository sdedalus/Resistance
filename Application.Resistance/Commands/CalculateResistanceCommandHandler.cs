using Application.Resistance.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Resistance.Commands
{
	public class CalculateResistanceCommandHandler : ICommandHandler<CalculateResistanceCommand, decimal>
	{
		public decimal Execute(CalculateResistanceCommand comand)
		{
			throw new NotImplementedException();
		}
	}
}

using Application.Resistance.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Resistance.Host.Controllers
{
	public class ResistanceController : ApiController
	{
		public ResistanceController(CommandMediator mediator)
		{

		}
		
		
		public IEnumerable<string> Get(string bandA, string bandB, string bandC)
		{
			return new string[] { "Hello", "World" };
		}
		
	}

}

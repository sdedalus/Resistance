using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace ResistanceCommon.IOC
{
	// This is just an idea I have been playing with.  Since this class needs to 'act' as a singleton 
	// and has to be in place before the IOC container is bootstrapped.  I also didn't want a useless 
	// init function hanging off of this class so I moved the init to a separate namespace 
	public class InversionOfControl
	{ }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistanceCommon.IOC
{
	using ResistanceCommon.IOC;
	public static class Initializer
	{
		public static void Initialize()
		{
			InversionOfControlImplementation.Initialize();
		}
	}
}

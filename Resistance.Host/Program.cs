namespace Resistance.Host
{
	using Microsoft.Owin.Hosting;
	using System;

	internal class Program
	{
		private static void Main(string[] args)
		{
			// set up the IOC container to prepare for bootstrap.
			ResistanceCommon.IOC.Initializer.Initialize();

			using (WebApp.Start<Startup>("http://localhost:8080"))
			{
				Console.WriteLine("Web Server is running.");
				Console.WriteLine("Press any key to quit.");
				Console.ReadLine();
			}
		}
	}
}
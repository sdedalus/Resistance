using Owin;
using Microsoft.Owin.Hosting.Builder;
using System;
using System.Web.Http;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Microsoft.Practices.Unity;
using Microsoft.Owin.Hosting;
using ResistanceCommon.IOC;
using Unity.WebApi;

namespace Resistance.Host
{
	public class Startup
	{
		private static InversionOfControl inversionOfControl;
		// Your startup logic
		public static void StartServer()
		{
			string baseAddress = "http://localhost:8081/";
			inversionOfControl = new InversionOfControl();

			Startup startup = inversionOfControl.Container().Resolve<Startup>();

			Bootstrapper bootstrapper = new Bootstrapper(inversionOfControl);
			//options.ServerFactory = "Microsoft.Owin.Host.HttpListener"
			IDisposable webApplication = WebApp.Start(baseAddress, startup.Configuration);
			
			try
			{
				Console.WriteLine("Started...");

				Console.ReadKey();
			}
			finally
			{
				webApplication.Dispose();
			}
		}


		public void Configuration(IAppBuilder app)
		{
			// Configure Web API for self-host. 
			var config = new HttpConfiguration();

			// Add Unity DependencyResolver
			config.DependencyResolver = new UnityDependencyResolver(inversionOfControl.Container());


			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			var physicalFileSystem = new PhysicalFileSystem(@".\Web"); //. = root, Web = your physical directory that contains all other static content, see prev step
			var options = new FileServerOptions
			{
				EnableDefaultFiles = true,
				FileSystem = physicalFileSystem
			};
			options.StaticFileOptions.FileSystem = physicalFileSystem;
			options.StaticFileOptions.ServeUnknownFileTypes = true;
			options.DefaultFilesOptions.DefaultFileNames = new[] { "index.html" }; //put whatever default pages you like here
			app.UseFileServer(options);

			app.UseWebApi(config);
		}
	}
}

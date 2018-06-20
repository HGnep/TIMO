//using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
/*
using TIMO.Controllers;
using TIMO.data;
using TIMO.Services;
*/

namespace TIMO
{
	public class Program
	{
		public static void Main (string[] args)
		{
			BuildWebHost(args).Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.ConfigureAppConfiguration((hostContext, config) => {
					config.Sources.Clear();
					config.AddJsonFile("appsettings.json", optional: true);
				})
				.Build();
	}
}

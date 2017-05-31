//using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
/*
using TIMO.Controllers;
using TIMO.data;
using TIMO.Services;
*/

namespace TIMO {
	public class Program {
		public static void Main(string[] args) {

		var host = new WebHostBuilder()
			.UseKestrel()
			.UseContentRoot(Directory.GetCurrentDirectory())
			.UseIISIntegration()
			.UseStartup<Startup>()
			.Build();
			host.Run();
		/*
			using (var db = new TimoDbContext()) {
				var relatieService = new RelatieService(db);
				var relatieController = new RelatieController(db, relatieService);
				var running = true;

				while (running) {
					Console.WriteLine();
					Console.WriteLine("Wat wil je doen?");
					Console.WriteLine("Keuzes: ");
					Console.WriteLine("1. Tabel weergeven");
					Console.WriteLine("2. Nieuwe relatie toevoegen");
					Console.WriteLine("3. Relatie verwijderen");
					Console.WriteLine("4. Sluit programma");

					Console.WriteLine("Keuze: ");
					var keuze = int.Parse(Console.ReadLine());

					if (keuze == 1) {
						relatieController.ReadTable();
					}
					else if (keuze == 2) {
						relatieController.Create();
					}
					else if (keuze == 3) {
						relatieController.Delete();
					}
					else if (keuze == 4) {
						running = false;
					}
					else {
						Console.WriteLine("Dit is geen geldige keuze.");
					}
				}
			}
		*/
		}
	}
}
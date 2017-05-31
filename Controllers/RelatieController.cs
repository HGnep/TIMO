using Microsoft.AspNetCore.Mvc;
//using TIMO.data;
using TIMO.Services;

namespace TIMO.Controllers {
	public class RelatieController : Controller {

		//private TimoDbContext _db;
		private IRelatieService _relatieService;

		//GET: /Relatie/
		public IActionResult Index() {
			var model = _relatieService.ReadAll();
			return View(model);
		}

		public ActionResult Create() {
			return PartialView();
		}


		public ActionResult Read(int RelatieId) {
			var model = _relatieService.Read(RelatieId);
			return PartialView(model);
		}



		public RelatieController(IRelatieService iRelatieService) {
			_relatieService = iRelatieService;
		}



/*
		public RelatieController(TimoDbContext dbContext, RelatieService relatieService) {
			_db = dbContext;
			_relatieService = relatieService;
		}

		//GET: /Relatie/Create
		public void Create() {
			Console.WriteLine("Wie wil je toevoegen?");
			Console.WriteLine("Voornaam: ");
			var voornaam = Console.ReadLine();
			Console.WriteLine("Tussenvoegsel: ");
			var tussenvoegsel = Console.ReadLine();
			Console.WriteLine("Achternaam: ");
			var achternaam = Console.ReadLine();
			Console.WriteLine("Straat: ");
			var straat = Console.ReadLine();
			Console.WriteLine("Postcode: ");
			var postcode = Console.ReadLine();
			Console.WriteLine("Woonplaats: ");
			var woonplaats = Console.ReadLine();

			var relatie = new Relatie{Voornaam = voornaam, Tussenvoegsel = tussenvoegsel, Achternaam = achternaam, Straat = straat, Huisnummer = 5, Postcode = postcode, Woonplaats = woonplaats};

			int id = _relatieService.Create(relatie);
			Relatie savedRelatie = _relatieService.Read(id);
			Console.WriteLine("{0} is aan de tabel toegevoegd", savedRelatie.VolledigeNaam);
		}

		//GET: /Relatie/ReadTable
		public void ReadTable() {
			Console.WriteLine();
			Console.WriteLine("All clients in database:");
			foreach (var client in _db.Relaties) {
				Console.WriteLine();
				Console.WriteLine(" {0}.\n{1} \n {2}", client.RelatieId, client.VolledigeNaam, client.VolledigAdres);
			}
		}

		//GET: /Relatie/Delete
		public void Delete() {
			Console.WriteLine();
			Console.WriteLine("Wie wil je verwijderen?");
			var id = int.Parse(Console.ReadLine());
			Relatie r = _relatieService.Read(id);
			Console.WriteLine(r.VolledigeNaam);
			_relatieService.Delete(r);
		}*/
	}
}
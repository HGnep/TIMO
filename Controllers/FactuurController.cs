using Microsoft.AspNetCore.Mvc;

namespace TIMO.Controllers{
	public class FactuurController : Controller {

		public IActionResult Index () {
			ViewData["Title"] = "Facturen";

			return View("Nonexistent");
		}
	}
}
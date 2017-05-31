using Microsoft.AspNetCore.Mvc;

namespace TIMO.Controllers{
	public class UurController : Controller {

		public IActionResult Index () {
			ViewData["Title"] = "Uren";

			return View("Nonexistent");
		}
	}
}
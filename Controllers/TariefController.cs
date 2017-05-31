using Microsoft.AspNetCore.Mvc;

namespace TIMO.Controllers{
	public class TariefController : Controller {

		public IActionResult Index () {
			ViewData["Title"] = "Tarieven";

			return View("Nonexistent");
		}
	}
}
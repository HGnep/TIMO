using Microsoft.AspNetCore.Mvc;

namespace TIMO.Controllers {
	public class HomeController : Controller {

		//GET: /index/
		public IActionResult Index() {
			ViewData["Title"] = "Home";
			return View("Nonexistent");
		}
	}
}
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.Controllers
{
	public class ExperienceController : Controller
	{
		public IActionResult ExperienceList()
		{
			return View();
		}
	}
}

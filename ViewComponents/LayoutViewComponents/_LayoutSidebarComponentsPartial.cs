using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentsPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}

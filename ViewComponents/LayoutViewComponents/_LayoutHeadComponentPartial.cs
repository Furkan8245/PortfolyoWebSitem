using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{ 
			return View(); 
		}
	}
}

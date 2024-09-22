using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents
{
	public class _ExperienceComponentPartical:ViewComponent
	{
		MyPortfolioContext context=new MyPortfolioContext();																								
		public IViewComponentResult Invoke()
		{
			var values=context.Experiences.ToList();	
			return View(values);

		}

	}
}

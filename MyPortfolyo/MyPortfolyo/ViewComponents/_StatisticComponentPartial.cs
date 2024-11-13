using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { 
        return View();
        }
    }
}

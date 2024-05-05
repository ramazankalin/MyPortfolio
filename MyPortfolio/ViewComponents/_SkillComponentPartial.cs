using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext myPortfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = myPortfolioContext.Skills.ToList();
            return View(values);
        }
    }
}

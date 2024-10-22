using Microsoft.AspNetCore.Mvc;
using VIewComponentsPractice.Models;

namespace VIewComponentsPractice.ViewComponents
{
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PersonGridModel grid)
        {


            return View(grid); //invoked a partial view in shared folder
            //views/shared/Components/Grid/default.cshtml
        }
    }
}

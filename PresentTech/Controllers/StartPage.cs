using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using PresentTech.Models.Pages;
using System.Web.Mvc;

namespace PresentTech.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public IActionResult Index(StartPage currentPage)
        {
            return View(currentPage);//test
        }
    }
}

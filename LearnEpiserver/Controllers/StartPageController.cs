using EPiServer.Web.Mvc;
using LearnEpiserver.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnEpiserver.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        // GET: StartPage
        public ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}
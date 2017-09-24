using EPiServer.Web.Mvc;
using LearnEpiserver.Models.Pages;
using System;
using System.Web.Mvc;
using System.Web.Security;

namespace LearnEpiserver.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
        // Providing a logout action for the page.
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}
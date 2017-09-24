using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using LearnEpiserver.Models.Pages;
using System.Web.Security;

namespace LearnEpiserver.Controllers
{
    [TemplateDescriptor(Default = true)]
    public class ArticlePageController : PageControllerBase<ArticlePage>
    {
        // GET: ArticlePage
        public ActionResult Index(ArticlePage currentPage)
        {
            // Implementation of action view the page. 
            return View(currentPage);
        }
    }
}
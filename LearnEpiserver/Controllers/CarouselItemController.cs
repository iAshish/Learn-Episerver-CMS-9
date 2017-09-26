using EPiServer.Web.Mvc;
using LearnEpiserver.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnEpiserver.Controllers
{
    public class CarouselItemController : BlockController<CarouselItemBlock>
    {
        // GET: CarouselItem
        public override ActionResult Index(CarouselItemBlock currentblock)
        {
            return PartialView(currentblock);
        }
    }
}
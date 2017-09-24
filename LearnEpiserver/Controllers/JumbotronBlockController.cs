using EPiServer.Web.Mvc;
using LearnEpiserver.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnEpiserver.Controllers
{
    public class JumbotronBlockController :  BlockController<JumbotronBlock>
    {
        // GET: JumbotronBlock
        public override ActionResult Index(JumbotronBlock currentblock)
        {
            return PartialView(currentblock);
        }
    }
}
using EPiServer.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace LearnEpiserver.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        [Display(GroupName = "SEO", Order = 200, Name = "Search keywords")]
        public virtual String MetaKeywords { get; set; }
    }
}
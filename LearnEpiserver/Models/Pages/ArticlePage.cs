using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace LearnEpiserver.Models.Pages
{
    [ContentType(DisplayName = "ArticlePage", GUID = "f05506a4-38a4-4fef-bd19-b3bd77ca6a1f", Description = "Basic page type for creating articles.")]
    public class ArticlePage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title of the Article",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Author",
            Description = "Name of the Author",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string Author { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Posted On",
            Description = "Date time article posted on",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual DateTime PostedOn { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Location",
            Description = "Location Details",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual string Location { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Tags",
            Description = "Tags for articles",
            GroupName = SystemTabNames.Content,
            Order = 6)]
        public virtual string Tags { get; set; }

    }
}
using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer;

namespace LearnEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "CarouselItemBlock", GUID = "6b20e397-6240-4e7d-98a7-87daa51d44d4", Description = "")]
    public class CarouselItemBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title on Carousel Item",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Description",
            Description = "Description on Carousel Item",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString Description { get; set; }

        [Display(
            Name = "Image",
            Description = "Image url for the Carousel Item",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual Url Image { get; set; }

        [Display(
            Name = "Navigation Url",
            Description = "Navigation Url for the Carousel Item",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual Url NavigationUrl { get; set; }
    }
}
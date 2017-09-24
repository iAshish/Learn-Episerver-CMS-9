using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer;

namespace LearnEpiserver.Models.Blocks
{
    [ContentType(DisplayName = "JumbotronBlock", GUID = "aa7c7041-6f16-4526-9f88-794e9ba3db3a", Description = "Jumbotron block type with header, description, image")]
    public class JumbotronBlock : BlockData
    {
        
        [Display(
            Name = "Header",
            Description = "Header for the block",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [Required]
        public virtual string Header { get; set; }


        
        [Display(
            Name = "Description",
            Description = "Description for the block",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [Required]
        public virtual XhtmlString Description { get; set; }

        
        [Display(
            Name = "Image",
            Description = "Choose Image for the block",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [Required]
        public virtual Url Image { get; set; }

        
        [Display(
            Name = "Button label",
            Description = "Enter label for a button",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        [Required]
        public virtual string Button { get; set; }

        
        [Display(
           Name = "Url",
           Description = "Enter url for a button",
           GroupName = SystemTabNames.Content,
           Order = 5)]
        [Required]
        public virtual Url Url { get; set; }

    }
}
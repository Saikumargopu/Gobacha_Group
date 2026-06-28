using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PresentTech.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "838f1616-1e79-40fc-afb4-561f02b8d0be", Description = "")]
    public class StartPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string body { get; set; }
        [CultureSpecific]
        [Display(
            Name = "Cheer",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Cheer { get; set; }
        [CultureSpecific]
        [Display(
            GroupName = Globals.GroupNames.MetaData,
            Order = 200)]
        public virtual string bate { get; set; }

    }
}

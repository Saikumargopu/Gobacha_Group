using System.ComponentModel.DataAnnotations;

namespace PresentTech
{
    public class Globals
    {
        public const string LoginPath = "/util/login";

        /// <summary>
        /// Group names for content types and properties
        /// </summary>
        [GroupDefinitions]
        public static class GroupNames
        {
            [Display(Name = "Default", Order = 10)]
            public const string Default = "Default";

            [Display(Name = SystemTabNames.Content, Order = 20)]
            public const string Content = SystemTabNames.Content;

            [Display(Name = "Contact", Order = 30)]
            public const string Contact = "Contact";

            [Display(Name = "Metadata", Order = 40)]
            public const string MetaData = "Metadata";

            [Display(Name = "News", Order = 50)]
            public const string News = "News";

            [Display(Name = "Products", Order = 60)]
            public const string Products = "Products";

            [Display(Name = SystemTabNames.Settings, Order = 70)]
            public const string Settings = SystemTabNames.Settings;

            [Display(Name = "SiteSettings", Order = 80)]
            public const string SiteSettings = "SiteSettings";

            [Display(Name = "Specialized", Order = 90)]
            public const string Specialized = "Specialized";
        }
    }
}

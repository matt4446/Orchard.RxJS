using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orchard.UI.Navigation;
using Orchard.Localization;
using Orchard.Environment.Extensions;

namespace Orchard.RxJS
{
    [OrchardFeature("Orchard.RxJs.Samples")]
    public class AdminMenu : INavigationProvider
    {
        public AdminMenu() 
        {
            
        }

        public Localizer T { get; set; }
        public string MenuName { get { return "admin"; } }

        public void GetNavigation(NavigationBuilder builder)
        {
            builder.AddImageSet("navigation")
                .Add(T("RxJS Demos"), "9", menu =>
                {
                    menu.Add(T("Demo"), "0", item => item.Action("Index", "Admin", new { Area = "Orchard.RxJs" }));
                });

        }
    }
}

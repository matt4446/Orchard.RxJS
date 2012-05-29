using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Orchard.Environment.Extensions;
using Orchard.UI.Admin;

namespace Orchard.RxJS.Controllers
{
    [OrchardFeature("Orchard.RxJs.Samples")]
    [Admin]
    public class AdminController : Controller 
    {
        public AdminController() 
        { 
        }

        public ActionResult Index() 
        {
            return View();
        }

        public ActionResult DictionarySuggest() 
        {
            return View();
        }

        public ActionResult MouseMove() 
        {
            return View();
        }
    }
}

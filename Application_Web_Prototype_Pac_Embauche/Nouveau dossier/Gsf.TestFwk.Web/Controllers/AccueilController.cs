using System.Collections.Generic;
using System.Web.Mvc;
using System.Security.Claims;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using System;
using System.Linq;
using Gsf.Framework.Web.Securite;
using Gsf.Framework.Serialization;
using Gsf.Framework.Web.Securite.Owin;
using Gsf.Framework.Web;
using Gsf.TestFwk.Web.ServiceHR;
using Gsf.TestFwk.Web.Models;
using Kendo.Mvc.UI.Html;

namespace Gsf.TestFwk.Web.Controllers
{
    public partial class AccueilController : Gsf.Framework.Web.MVC.Controllers.GsfBaseController
    {

        // GET: Collaborateur
        public ActionResult Collaborateur()
        {
            return View();
        }
    }
}
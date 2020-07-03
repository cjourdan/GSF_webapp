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
    public partial class SchedulerController : Gsf.Framework.Web.MVC.Controllers.GsfBaseController
    {
        public ActionResult Scheduling()
        {
            return View();
        }

        /*private SchedulerTaskService taskService;
        private SchedulerMeetingService meetingService;

        public SchedulerController()
        {
            this.taskService = new SchedulerTaskService();
            this.meetingService = new SchedulerMeetingService();
        }

        /*public virtual JsonResult Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(taskService.GetAll().ToDataSourceResult(request));
        }*/

        /*public ActionResult EmployeeSales([DataSourceRequest] DataSourceRequest request)
        {
            return Json(null);
        }*/
    }
}
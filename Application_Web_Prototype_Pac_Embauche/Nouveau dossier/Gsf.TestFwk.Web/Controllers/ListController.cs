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

    public partial class ListController : Gsf.Framework.Web.MVC.Controllers.GsfBaseController
    {

        // GET: Employee
        public ActionResult Listing()
        {
            return View();
        }
       
        public ActionResult EmployeesList([DataSourceRequest] DataSourceRequest request, Int32? matricule, String str_date)
        {

            string li_matricule_employees = "7251";
            str_date = "";

            if (li_matricule_employees != null)
            {
               




                Association_String_WS WS_CALLBACK = Association_String_WS.getInstance();
                WS_CALLBACK.initAllCallbackWithoutParameters();


                object[] parameters = {new ServiceHR.RequestListeMemberDto() { matricule = li_matricule_employees, date = str_date }};
                

                List<MemberDto> lo_dossiers = ((MemberDto[])WS_CALLBACK.call("team",parameters)).ToList();
                
                
                
                //List<MemberDto> lo_dossiers = lo_service.getTeam(new ServiceHR.RequestListeMemberDto() { matricule = li_matricule_employees, date = str_date }).ToList();
                //264075901

                lo_dossiers.Count();


                //var lo_MesDossiers = lo_dossiers.Select(test => new RecupDossier
                //{
                //    RDosNom = test.lastname,
                //    RDosPrenom = test.firstname,
                //    Matricule = Convert.ToInt32(test.matricule),
                //    RDosMatriculePres = test.matricule
                //});

                IEnumerable<RecupDossier> lo_MesDossiers = (from test in lo_dossiers
                                                            select new RecupDossier()
                                                            {
                                                                RDosNom = test.lastname,
                                                                RDosPrenom = test.firstname,
                                                                Matricule = Convert.ToInt32(test.matricule),
                                                                RDosMatriculePres = test.matricule,
                                                            });
                return Json(lo_MesDossiers.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null);
            }
        }
    }
}
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
using Kendo.Mvc;

namespace Gsf.TestFwk.Web.Controllers
{
    public partial class FicheController : Gsf.Framework.Web.MVC.Controllers.GsfBaseController
    {
        // GET: FicheIndicative
        public ActionResult FicheIndicative()
        {
            return View();
        }
     
        public ActionResult FicheIndicative_Employees([DataSourceRequest] DataSourceRequest request)
        {
            string li_matricule_employees = string.Empty;
            var filter = request.Filters.FirstOrDefault();

            if (filter != null)
            {
                var descriptor = filter as FilterDescriptor;
                if (descriptor != null && descriptor.Member == "Matricule")
                {
                    li_matricule_employees = descriptor.Value.ToString();
                }
            }


            if (!string.IsNullOrEmpty(li_matricule_employees))
            {
                
                Association_String_WS WS_CALLBACK = Association_String_WS.getInstance();
                WS_CALLBACK.initAllCallbackWithoutParameters();
              
                //EmployeDto la_fiche = lo_service.getFicheEmploye(new ServiceHR.RequestFicheEmployeDto() { matricule = li_matricule_employees });


                object[] parameters = { new ServiceHR.RequestFicheEmployeDto() { matricule = li_matricule_employees } };


                EmployeDto la_fiche = ((EmployeDto)WS_CALLBACK.call("fiche", parameters));

                List<RecupDossier> lo_MesDossiers = new List<RecupDossier>();

                lo_MesDossiers.Add(new RecupDossier
                {
                    RDosMatriculePres = la_fiche.matricule,
                    RDosNom = la_fiche.nom,
                    RDosPrenom = la_fiche.prenom,
                    RDosSexe = la_fiche.sexe,
                    RDosAge = la_fiche.age,
                    RDosNomNaiss = la_fiche.nomNaiss,
                    RDosDateNaiss = la_fiche.dateNaiss,
                    RDosNationalite = la_fiche.nationalite,
                    RDosVilleNaiss = la_fiche.villeNaiss,
                    RDosNumSS = la_fiche.numSS,
                    //RDosEmail = la_fiche.email,
                    RDosSitFAm = la_fiche.sitFAm,
                    RDosNbKids = la_fiche.nbKids,
                    RDosNbPersCharge = la_fiche.nbPersCharge,
                    RDosAdresse = la_fiche.adresse
                });               
                
                //return Json(lo_MesDossiers.ToDataSourceResult(request));

                return Json(lo_MesDossiers.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null);
            }
        }        
    }
}

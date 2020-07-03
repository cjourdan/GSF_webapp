//using System.Collections.Generic;
//using System.Web.Mvc;
//using System.Security.Claims;
//using Kendo.Mvc.UI;
//using Kendo.Mvc.Extensions;
//using System;
//using System.Linq;
//using Gsf.Framework.Web.Securite;
//using Gsf.Framework.Serialization;
//using Gsf.Framework.Web.Securite.Owin;
//using Gsf.Framework.Web;
//using Gsf.TestFwk.Web.ServiceHR;
//using Gsf.TestFwk.Web.Models;
//using Kendo.Mvc.UI.Html;
//using Gsf.Framework.Web.MVC.URLEncryption;



//namespace Gsf.TestFwk.Web.Controllers
//{
//    public class HomeController : Gsf.Framework.Web.MVC.Controllers.GsfBaseController
//    {

//        public ActionResult Collaborateur()
//        {
//            return View();
//        }

//        public ActionResult Index()
//        {
//            //ServiceHR.POCServicePortTypeClient lo_service = new ServiceHR.POCServicePortTypeClient();
//            //lo_service.Open();
//            //List<DossierHR> lo_dossiers = lo_service.getHRDossier(new ServiceHR.RequestDossier() { user = "MOBILHR", pwd = "+GSF2015", numDoss = 26407, DateEmbauche = new DateTime(2015, 1, 1), DateDebutGTA = new DateTime(2010, 1, 1), DateFinGTA = new DateTime(2010, 1, 31), nom = "", prenom = "" }).ToList();
//            //264075901
//            //lo_dossiers.Count();
//            //lo_service.Close();
//            //ViewBag.lo_dossiers = lo_dossiers[0];

//            return View();
//        }

//        /*public JsonResult ListBinding_Employees() //[DataSourceRequest] DataSourceRequest request)
//        {
//            ServiceHR.POCServicePortTypeClient lo_service = new ServiceHR.POCServicePortTypeClient();

//            lo_service.Open();
//            List<DossierHR> lo_dossiers = lo_service.getHRDossier(new ServiceHR.RequestDossier() { user = "MOBILHR", pwd = "+GSF2015", numDoss = 26407, DateEmbauche = new DateTime(2015, 1, 1), DateDebutGTA = new DateTime(2010, 1, 1), DateFinGTA = new DateTime(2010, 1, 31), nom = "", prenom = "" }).ToList();
//            //264075901
//            lo_dossiers.Count();
//            lo_service.Close();

//            //List<SelectListItem> MaListe = new List<SelectListItem>();


//            IEnumerable<RecupDossier> lo_MesDossiers = (from test in lo_dossiers
//                                                        select new RecupDossier()
//                                                        {
//                                                            RDosNom = test.nom,
//                                                            RDosPrenom = test.prenom,
//                                                            RDosAge = test.age,
//                                                            RDosDateEntreeSoc = test.dateEntSoc,
//                                                            Matricule = Convert.ToInt32(test.matriculeNew),
//                                                            RDosMatriculePres = test.matriculeNew,
//                                                            RDosNumSS = test.numSS,
//                                                            RDosDateSortie = test.ES[0].DateSortie[0],
//                                                            RDosDateEntree = test.ES[0].DateEntree[0],
//                                                            RDosMotifEntree = test.ES[0].MotifEntree[0],
//                                                            RDosMotifEntreeLib = test.ES[0].MotifEntreeLib[0],
//                                                            RDosMotifSortie = test.ES[0].MotifSortie[0],
//                                                            RDosMotifSortieLib = test.ES[0].MotifSortieLib[0],
//                                                            RDosDateDebAF = test.Affect[0].DateDebut[0],
//                                                            RDosDateFinAF = test.Affect[0].DateFin[0],
//                                                            RDosEmploiAF = test.Affect[0].Emploi[0],
//                                                            RDosEmploiLibAF = test.Affect[0].EmploiLib[0],
//                                                            //model_date_sortie = test.ES[0].DateSortie[0],
//                                                            //model_date_entree = test.ES[0].DateEntree[0],
//                                                            //model_motif_entree = test.ES[0].MotifEntree[0],
//                                                            //model_motif_entree_lib = test.ES[0].MotifEntreeLib[0],
//                                                            //model_motif_sortie = test.ES[0].MotifSortie[0],
//                                                            //model_motif_sortie_lib = test.ES[0].MotifSortieLib[0],
//                                                        });
//            //int i = 0;
//            //for (i = 0; i < lo_MesDossiers.Count(); i++)
//            //{
//            //    MaListe.Add(new SelectListItem {Text = lo_MesDossiers.ElementAt(i).RDosNom, Value = i.ToString()});         
//            //}
//            //return Json(lo_dossiers.ToList());
//            //return Json(lo_dossiers.ToDataSourceResult(request));     
//            return Json(lo_MesDossiers.Select(o => new { Value = o.Matricule, Text = o.RDosNom + " " + o.RDosPrenom }), JsonRequestBehavior.AllowGet);
//            //return Json(lo_MesDossiers.ToDataSourceResult(request, o => new { v = o.Matricule, t = o.RDosNom }));

//            //return lo_MesDossiers.ToList();
//        }*/

//        //public ActionResult Salarie_Read(int numSS, [DataSourceRequest]DataSourceRequest request)
//        //{

//        //    ServiceHR.POCServicePortTypeClient lo_service = new ServiceHR.POCServicePortTypeClient();

//        //    lo_service.Open();
//        //    List<DossierHR> lo_dossiers = lo_service.getHRDossier(new ServiceHR.RequestDossier() { user = "MOBILHR", pwd = "+GSF2015", numDoss = 264075901, DateEmbauche = new DateTime(2015, 1, 1), DateDebutGTA = new DateTime(2010, 1, 1), DateFinGTA = new DateTime(2010, 1, 31), nom = "", prenom = "" }).ToList();
//        //    //264075901
//        //    lo_dossiers.Count();
//        //    lo_service.Close();

//        //    IEnumerable<RecupDossier> lo_MesDossiers = (from test in lo_dossiers
//        //                                                select new RecupDossier()
//        //                                               {
//        //                                                   model_nom = test.nom,
//        //                                                   model_prenom = test.prenom,
//        //                                                   model_age = test.age,
//        //                                                   model_date_entree_soc = test.dateEntSoc,
//        //                                                   model_matircule = test.matriculeNew,
//        //                                                   model_date_sortie = test.ES[0].DateSortie[0],
//        //                                                   model_date_entree = test.ES[0].DateEntree[0],
//        //                                                   model_motif_entree = test.ES[0].MotifEntree[0],
//        //                                                   model_motif_entree_lib = test.ES[0].MotifEntreeLib[0],
//        //                                                   model_motif_sortie = test.ES[0].MotifSortie[0],
//        //                                                   model_motif_sortie_lib = test.ES[0].MotifSortieLib[0],
//        //                                               });

//        //    //return Json(lo_dossiers.ToList());
//        //    //return Json(lo_dossiers.ToDataSourceResult(request));
//        //    return Json(lo_MesDossiers.ToDataSourceResult(request));
//        //}

//    }

//    public partial class GridController : Controller
//    {
//        public ActionResult Hierarchy()
//        {
//            return View();
//        }



//        // Données Tableau Principal

//        public ActionResult HierarchyBinding_Employees([DataSourceRequest] DataSourceRequest request, Int32? matricule, String nomParam, String prenomParam, DateTime dateEmbParam)
//        {
//            ServiceHR.POCServicePortTypeClient lo_service = new ServiceHR.POCServicePortTypeClient();
//            if (matricule != null)
//            {
//                lo_service.Open();
//                List<DossierHR> lo_dossiers = lo_service.getHRDossier(new ServiceHR.RequestDossier() { user = "MOBILHR", pwd = "+GSF2015", numDoss = matricule.GetValueOrDefault(0), DateEmbauche = new DateTime(2015, 1, 1), DateDebutGTA = new DateTime(2010, 1, 1), DateFinGTA = new DateTime(2010, 1, 31), nom = nomParam, prenom = prenomParam }).ToList();
//                //264075901
//                lo_dossiers.Count();
//                lo_service.Close();

//                IEnumerable<RecupDossier> lo_MesDossiers = (from test in lo_dossiers
//                                                            select new RecupDossier()
//                                                            {
//                                                                RDosNom = test.nom,
//                                                                RDosPrenom = test.prenom,
//                                                                RDosAge = test.age,
//                                                                RDosDateEntreeSoc = test.dateEntSoc,
//                                                                Matricule = Convert.ToInt32(test.matriculeNew),
//                                                                RDosMatriculePres = test.matriculeNew,
//                                                                RDosNumSS = test.numSS,
//                                                                RDosDateSortie = test.ES[0].DateSortie[0],
//                                                                RDosDateEntree = test.ES[0].DateEntree[0],
//                                                                RDosMotifEntree = test.ES[0].MotifEntree[0],
//                                                                RDosMotifEntreeLib = test.ES[0].MotifEntreeLib[0],
//                                                                RDosMotifSortie = test.ES[0].MotifSortie[0],
//                                                                RDosMotifSortieLib = test.ES[0].MotifSortieLib[0],
//                                                                RDosDateDebAF = test.Affect[0].DateDebut[0],
//                                                                RDosDateFinAF = test.Affect[0].DateFin[0],
//                                                                RDosEmploiAF = test.Affect[0].Emploi[0],
//                                                                RDosEmploiLibAF = test.Affect[0].EmploiLib[0],
//                                                                //model_date_sortie = test.ES[0].DateSortie[0],
//                                                                //model_date_entree = test.ES[0].DateEntree[0],
//                                                                //model_motif_entree = test.ES[0].MotifEntree[0],
//                                                                //model_motif_entree_lib = test.ES[0].MotifEntreeLib[0],
//                                                                //model_motif_sortie = test.ES[0].MotifSortie[0],
//                                                                //model_motif_sortie_lib = test.ES[0].MotifSortieLib[0],
//                                                            });

//                //return Json(lo_dossiers.ToList());
//                //return Json(lo_dossiers.ToDataSourceResult(request));            
//                return Json(lo_MesDossiers.ToDataSourceResult(request));
//            }
//            else
//            {
//                return Json(null);
//            }
//        }


//        // Données Sous Tableau 
//        [AllowClearQSAttribute(Params = "matricule")]
//        public ActionResult HierarchyBinding_EmployeeData([DataSourceRequest] DataSourceRequest request, String matricule)
//        {
//            int li_matricule = Convert.ToInt32(matricule);

//            ServiceHR.POCServicePortTypeClient lo_service = new ServiceHR.POCServicePortTypeClient();

//            lo_service.Open();
//            List<DossierHR> lo_dossiers = lo_service.getHRDossier(new ServiceHR.RequestDossier() { user = "MOBILHR", pwd = "+GSF2015", numDoss = li_matricule, DateEmbauche = new DateTime(2015, 1, 1), DateDebutGTA = new DateTime(2010, 1, 1), DateFinGTA = new DateTime(2010, 1, 31), nom = "", prenom = "" }).ToList();
//            //264075901
//            lo_dossiers.Count();
//            lo_service.Close();

//            IEnumerable<RecupData> lo_MesDossiers = (from test in lo_dossiers
//                                                     select new RecupData()
//                                                     {
//                                                         //model_nom = test.nom,
//                                                         //model_prenom = test.prenom,
//                                                         //model_age = test.age,
//                                                         //model_date_entree_soc = test.dateEntSoc,
//                                                         Matricule = Convert.ToInt32(test.matriculeNew),
//                                                         RDatDateSortie = test.ES[0].DateSortie[0],
//                                                         RDatDateEntree = test.ES[0].DateEntree[0],
//                                                         RDatMotifEntree = test.ES[0].MotifEntree[0],
//                                                         RDatMotifEntreeLib = test.ES[0].MotifEntreeLib[0],
//                                                         RDatMotifSortie = test.ES[0].MotifSortie[0],
//                                                         RDatMotifSortieLib = test.ES[0].MotifSortieLib[0],
//                                                     });

//            //return Json(lo_dossiers.ToList());
//            //return Json(lo_dossiers.ToDataSourceResult(request));
//            return Json(lo_MesDossiers.ToDataSourceResult(request));
//        }

//        public ActionResult GetEmployees()
//        {
//            var employees = new ServiceHR.POCServicePortTypeClient();

//            /*var employees = new (e => new RecupDossier
//            {
//                Matricule = e.matricule,
//                RDosNom = e.RDosNom,
//                RDosPrenom = e.RDosPrenom
//            }).OrderBy(e => e.Matricule);*/

//            return Json(employees, JsonRequestBehavior.AllowGet);
//        }

//        public ActionResult EmployeesList([DataSourceRequest]DataSourceRequest request, int? matricule)
//        {
//            int test_num = Convert.ToInt32(matricule);

//            // var employees = new ServiceHR.POCServicePortTypeClient();

//            ServiceHR.POCServicePortTypeClient lo_service = new ServiceHR.POCServicePortTypeClient();

//            lo_service.Open();
//            List<DossierHR> lo_dossiers = lo_service.getHRDossier(new ServiceHR.RequestDossier() { user = "MOBILHR", pwd = "+GSF2015", numDoss = matricule.GetValueOrDefault(0), DateEmbauche = new DateTime(2015, 1, 1), DateDebutGTA = new DateTime(2010, 1, 1), DateFinGTA = new DateTime(2010, 1, 31), nom = "", prenom = "" }).ToList();
//            //264075901
//            lo_dossiers.Count();
//            lo_service.Close();

//            IEnumerable<RecupData> lo_MesDossiers = (from test in lo_dossiers
//                                                     select new RecupData()
//                                                     {
//                                                         Matricule = Convert.ToInt32(test.matriculeNew),
//                                                         RDatDateSortie = test.ES[0].DateSortie[0],
//                                                         RDatDateEntree = test.ES[0].DateEntree[0],
//                                                         RDatMotifEntree = test.ES[0].MotifEntree[0],
//                                                         RDatMotifEntreeLib = test.ES[0].MotifEntreeLib[0],
//                                                         RDatMotifSortie = test.ES[0].MotifSortie[0],
//                                                         RDatMotifSortieLib = test.ES[0].MotifSortieLib[0],
//                                                     });

//            return Json(lo_MesDossiers.ToDataSourceResult(request));
//        }

//        /*public virtual JsonResult Meetings_Read([DataSourceRequest] DataSourceRequest request) 
//        { 
//             return Json(employees.GetAll().ToDataSourceResult(request)); 
//        } 
 
 
//        public virtual JsonResult Meetings_Destroy([DataSourceRequest] DataSourceRequest request, RecupDossier meeting) 
//        { 
//            if (ModelState.IsValid) 
//             { 
//                 meetingService.Delete(meeting, ModelState); 
//             } 
 
 
//             return Json(new[] { meeting }.ToDataSourceResult(request, ModelState)); 
//         } 
 
 
//         public virtual JsonResult Meetings_Create([DataSourceRequest] DataSourceRequest request, MeetingViewModel meeting) 
//         { 
//             if (ModelState.IsValid) 
//             { 
//                 meetingService.Insert(meeting, ModelState); 
//            } 
 
//             return Json(new[] { meeting }.ToDataSourceResult(request, ModelState)); 
//         } 
 
 
//         public virtual JsonResult Meetings_Update([DataSourceRequest] DataSourceRequest request, MeetingViewModel meeting) 
//         { 
//             if (ModelState.IsValid) 
//             { 
//                 meetingService.Update(meeting, ModelState); 
//             } 
 
 
//             return Json(new[] { meeting }.ToDataSourceResult(request, ModelState)); 
//         } */
//    }
//}
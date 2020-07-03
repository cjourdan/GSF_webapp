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
using Gsf.Framework.Web.MVC.URLEncryption;



namespace Gsf.TestFwk.Web.Controllers
{
    public partial class HomeController : Gsf.Framework.Web.MVC.Controllers.GsfBaseController
    {
        public ActionResult Index()
        {
            return View();
        }


        // Données Tableau Principal

        public ActionResult HierarchyBinding_Employees([DataSourceRequest] DataSourceRequest request, String numSS, DateTime dateEmbParam, String dt_dateDebutGTA, String dt_dateFinGTA, String nomParam, String prenomParam)
        {
            ServiceHR.POCServicePortTypeClient lo_service = new ServiceHR.POCServicePortTypeClient();

            //numSS = "1761083137292";
            numSS = "264075901";

            string str_dateEmbParam = dateEmbParam.ToString("yyyy-MM-dd");
            str_dateEmbParam = "2013-01-01";

            dt_dateDebutGTA = "2013-01-01";
            dt_dateFinGTA = "2013-05-01";

            //nomParam = "mercurin";
            //prenomParam = "jerome";

            if (numSS != null)
            {
                lo_service.Open();
                
                string nomParamMaj = nomParam.ToUpper();
                string prenomParamMaj = prenomParam.ToUpper();

                List<DossierHRDto> lo_dossiers = lo_service.getDossierHR(new ServiceHR.RequestDossierHRDto() { numSS = numSS, nom = nomParamMaj, prenom = prenomParamMaj, dateEmbauche = str_dateEmbParam, dateDebutGTA = dt_dateDebutGTA, dateFinGTA = dt_dateFinGTA }).ToList();
                //264075901

                lo_dossiers.Count();
                lo_service.Close();

                IEnumerable<RecupDossier> lo_MesDossiers = (from test in lo_dossiers
                                                            select new RecupDossier()
                                                            {
                                                                RDosNom = test.nom,
                                                                RDosPrenom = test.prenom,
                                                                RDosAge = Convert.ToInt16(test.age),
                                                                RDosDateEntreeSoc = test.dateEntSoc,
                                                                Matricule = Convert.ToInt32(test.matriculeNew),
                                                                RDosMatriculePres = test.matriculeNew,
                                                                RDosNumSS = test.numSS,
                                                                RDosDateSortie = Convert.ToDateTime(test.es[0].dateSortie[0]),
                                                                RDosDateEntree = Convert.ToDateTime(test.es[0].dateEntree[0]),
                                                                RDosMotifEntree = test.es[0].motifEntree[0],
                                                                RDosMotifEntreeLib = test.es[0].motifEntreeLib[0],
                                                                RDosMotifSortie = test.es[0].motifSortie[0],
                                                                RDosMotifSortieLib = test.es[0].motifSortieLib[0],
                                                                RDosDateDebAF = Convert.ToDateTime(test.affect[0].dateDebut[0]),
                                                                RDosDateFinAF = Convert.ToDateTime(test.affect[0].dateFin[0]),
                                                                RDosEmploiAF = test.affect[0].emploi[0],
                                                                RDosEmploiLibAF = test.affect[0].emploiLib[0],
                                                                //model_date_sortie = test.ES[0].DateSortie[0],
                                                                //model_date_entree = test.ES[0].DateEntree[0],
                                                                //model_motif_entree = test.ES[0].MotifEntree[0],
                                                                //model_motif_entree_lib = test.ES[0].MotifEntreeLib[0],
                                                                //model_motif_sortie = test.ES[0].MotifSortie[0],
                                                                //model_motif_sortie_lib = test.ES[0].MotifSortieLib[0],
                                                            });

                return Json(lo_MesDossiers.ToDataSourceResult(request));
            }
            else
            {
                return Json(null);
            }
        }

        // Données Sous Tableau 
        [AllowClearQSAttribute(Params = "numSS")]
        public ActionResult HierarchyBinding_EmployeeData([DataSourceRequest] DataSourceRequest request, Int32? numSS, String dateEmbauche, String dateDebutGTA, String dateFinGTA)
        {
            ServiceHR.POCServicePortTypeClient lo_service = new ServiceHR.POCServicePortTypeClient();

            dateEmbauche = "2013-01-01";
            dateDebutGTA = "2013-01-01";
            dateFinGTA = "2013-05-01";

            string nom = "MALFAIT";
            string prenom = "SYLVIANE";
            //string nom = "MERCURIN";
            //string prenom = "JEROME";

            string li_numSS = Convert.ToString(numSS);

            if (li_numSS != null)
            {
                lo_service.Open();
                //li_numSS = "00023705";
                //List<EntreeSortieDto> lo_dossiers = lo_service.getES(new ServiceHR.RequestListeESDto() { matricule = li_numSS }).ToList();
                List<SalarieDto> lo_dossiers = lo_service.getEmployes(new ServiceHR.RequestListeSalariesDto() { matricule = li_numSS, nom = nom, prenom = prenom, numSS = li_numSS, date = dateEmbauche }).ToList();
                
                //264075901s
                lo_dossiers.Count();
                lo_service.Close();

                IEnumerable<RecupData> lo_MesDossiers = (from test in lo_dossiers
                                                         select new RecupData()
                  {
                      //model_nom = test.nom,
                      //model_prenom = test.prenom,
                      //model_age = test.age,
                      //model_date_entree_soc = test.dateEntSoc,
                      Matricule = Convert.ToInt32(test.matricule),
                      Nom = test.nom,
                      Prenom = test.prenom, 
                      //RDatDateSortie = Convert.ToDateTime(test.dateSortie[0]),
                      //RDatDateEntree = Convert.ToDateTime(test.dateEntree[0]),
                      //RDatMotifSortieLib = test.motifEntreeLib[0],
                      //RDatMotifEntreeLib = test.motifEntreeLib[0],
                      //RDatDateSortie = test.es[0].dateSortie[0],
                      //RDatDateEntree = test.es[0].dateEntree[0],
                      //RDatMotifEntree = test.es[0].motifEntree[0],
                      //RDatMotifEntreeLib = test.es[0].motifEntreeLib[0],
                      //RDatMotifSortie = test.es[0].motifSortie[0],
                      //RDatMotifSortieLib = test.es[0].motifSortieLib[0],
                  });

                return Json(lo_MesDossiers.ToDataSourceResult(request));
            }
            else
            {
                return Json(null);
            }
        }
    }
}

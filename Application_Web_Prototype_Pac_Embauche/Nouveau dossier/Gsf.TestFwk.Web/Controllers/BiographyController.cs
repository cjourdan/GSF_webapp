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
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Gsf.TestFwk.Web.Controllers
{
    public partial class BiographyController : Gsf.Framework.Web.MVC.Controllers.GsfBaseController
    {
        public ActionResult Biography()
        {
            return View();
        }

        public ActionResult BiographyEmployee([DataSourceRequest] DataSourceRequest request, Int32? matricule)
        {
            //Update Scop : n ou normal pour passer en mode normal

            string li_matricule_employees = "7251";

            if (li_matricule_employees != null)
            {
                Association_String_WS WS_CALLBACK = Association_String_WS.getInstance();
                WS_CALLBACK.initAllCallbackWithoutParameters();


                object[] parameters = { new ServiceHR.RequestReadBlobZY00Dto() { matricule = li_matricule_employees }};

                byte[] imageData;

                // Create the byte array.
                var originalImage = Image.FromFile(@"C:\original.bmp");
                using (var ms = new MemoryStream())
                {
                    originalImage.Save(ms, ImageFormat.Jpeg);
                    imageData = ms.ToArray();
                }

                // Convert back to image.
                using (var ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    //image.Save(@"C:\newImage.bmp");
                }

                List<HrBlobDto> lo_dossiers = ((HrBlobDto[])WS_CALLBACK.call("photo", parameters)).ToList();
                
                //264075901

                return Json(lo_dossiers.ToDataSourceResult(request));
            }
            else
            {
                return Json(null);
            }
        }
    }
}
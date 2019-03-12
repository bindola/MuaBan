using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;
using MuaBan.Models;

namespace MuaBan.Controllers
{
    public class SiteShareLayoutController : SurfaceController
    {
        private const String Patial_Path= "~/Views/Partials/ShareLayout/";
       
        public ActionResult RenderHeader()
        {
            return PartialView(string.Format("{0}Header.cshtml",Patial_Path));
        }


        public ActionResult RenderFooter()
        {
            return PartialView(string.Format("{0}Footer.cshtml",Patial_Path));

        }
    }

    
}
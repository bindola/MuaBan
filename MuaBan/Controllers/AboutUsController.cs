using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;
using Umbraco.Core.Models;

namespace MuaBan.Controllers
{
    public class AboutUsController:SurfaceController
    {
        private const String Patial_Path = "~/Views/Partials/AboutUs/";

        public ActionResult RenderSectionAboutUs()
        {
            return PartialView(string.Format("{0}SectionAboutUs.cshtml", Patial_Path));
        }
    }
}
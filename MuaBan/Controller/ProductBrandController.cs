using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;
using Umbraco.Core.Models;


namespace MuaBan.Controller
{
    public class ProductBrandController:SurfaceController
    {
        private const String Patial_Path = "~/Views/Partials/ProductBrand/";

        public ActionResult RenderSectionBrand()
        {
            return PartialView(string.Format("{0}SectionBrand.cshtml", Patial_Path));
        }
    }
}
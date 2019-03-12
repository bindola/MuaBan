using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;
using Umbraco.Core.Models;

namespace MuaBan.Controllers
{
    public class ProductDetailController : SurfaceController
    {
        private const String Patial_Path = "~/Views/Partials/ProductDetail/";

        public ActionResult RenderSectionDetail()
        {
            return PartialView(string.Format("{0}SectionDetail.cshtml", Patial_Path));
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;
using Umbraco.Core.Models;



namespace MuaBan.Controller 
{
    public class HomeController : SurfaceController
    {
        private const String Patial_Path = "~/Views/Partials/Home/";

        public ActionResult RenderNavigation()
        {
            return PartialView(string.Format("{0}Navigation.cshtml", Patial_Path));
        }

        public ActionResult RenderSection1()
        {        
            return PartialView(string.Format("{0}Section1.cshtml", Patial_Path));
        }
     
    }
}
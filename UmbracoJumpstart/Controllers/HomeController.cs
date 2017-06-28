using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace UmbracoJumpstart.Controllers  
{
    public class HomeController:Controller
    {
        private UmbracoContext umbracoContext;
        public HomeController()
        {
            umbracoContext = UmbracoContext.Current;
        }

        public ActionResult About()
        {
            var rootNode = umbracoContext.ContentCache.GetById(1064);
            var model = new RenderModel(rootNode,Thread.CurrentThread.CurrentCulture);
            
            return View(model);
        }
    }
}
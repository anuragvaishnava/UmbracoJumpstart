using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;
using Umbraco.Web;

namespace UmbracoJumpstart
{
    public class CustomUmbracoApplication:UmbracoApplication
    {

        protected override IBootManager GetBootManager()
        {
            return new CustomBootManager(this);
        }
    }

    class CustomBootManager : WebBootManager
    {
        public CustomBootManager(UmbracoApplicationBase umbracoApplication) : base(umbracoApplication)
        {
        }

        public override IBootManager Complete(Action<ApplicationContext> afterComplete)
        {
            RouteTable.Routes.MapRoute(
                    "Home", "Home/About", new { controller = "Home", action = "About" });
            
            return base.Complete(afterComplete);
        }

    }
}
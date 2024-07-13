using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Configuration;


namespace TestAPI
{
    public class TestController : AsyncController
    {
        [ActionName("TestMethod")]
        public JsonResult TestMethod()
        {
            var appSettings = AppSettings;
            if (appSettings.Count > 0)
            {
                var settingValue = appSettings["Test"];
            }

            return  Json("Hello there...", JsonRequestBehavior.AllowGet);
        }

        public static NameValueCollection AppSettings { 
            get { return System.Configuration.ConfigurationManager.AppSettings; } 
        }

    }
}

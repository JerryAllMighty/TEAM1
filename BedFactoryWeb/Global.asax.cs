using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Web.Configuration;
using EncryptDecryp;

namespace BedFactoryWeb
{
    public class Global : HttpApplication
    {
        public static string strConn = string.Empty;

        void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            strConn = WebConfigurationManager.ConnectionStrings["BedFactoryDB"].ConnectionString;

            AES aes = new AES();
            strConn = aes.AESDecrypt256(strConn);
            
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}
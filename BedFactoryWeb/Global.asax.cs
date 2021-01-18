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
            // 애플리케이션 시작 시 실행되는 코드
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            GlobalConfiguration.Configure(WebApiConfig.Register);

            strConn = WebConfigurationManager.ConnectionStrings["MesDB"].ConnectionString;

            AES aes = new AES();
            strConn = aes.AESDecrypt256(strConn);
            
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}
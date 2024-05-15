using BodyForgeServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BodyForgeServer.WebService
{
    /// <summary>
    /// Summary description for AuthenticationWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AuthenticationWebService : System.Web.Services.WebService
    {
        private AuthenticationService authenticationService;

        public AuthenticationWebService()
        {
            authenticationService = new AuthenticationService();
        }

        [WebMethod]
        public bool login(string username, string password)
        {
            return authenticationService.login(username, password);
        }
    }
}

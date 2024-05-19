using BodyForgeServer.Entity;
using BodyForgeServer.Service;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BodyForgeServer.WebService
{
    /// <summary>
    /// Summary description for UserWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserWebService : System.Web.Services.WebService
    {
        private UserService userService;

        public UserWebService()
        {
            userService = new UserService();
        }

        [WebMethod]
        public Users getById(long id)
        {
            try
            {
                return userService.getById(id);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [WebMethod]
        public Users getByUsername(string username)
        {
            try
            {
                return userService.getByUsername(username);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [WebMethod]
        public bool addUser(Users user)
        {
            try
            {
                userService.addUser(user);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

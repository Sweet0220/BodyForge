using BodyForgeServer.Entity;
using BodyForgeServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BodyForgeServer.WebService
{
    /// <summary>
    /// Summary description for ExerciseWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ExerciseWebService : System.Web.Services.WebService
    {

        private ExerciseService exerciseService;

        public ExerciseWebService()
        {
            exerciseService = new ExerciseService();
        }

        [WebMethod]
        public Exercise getById(long id)
        {
            return exerciseService.getById(id);
        }
    }
}

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
    /// Summary description for TargetWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TargetWebService : System.Web.Services.WebService
    {

        private TargetService targetService;

        public TargetWebService()
        {
            targetService = new TargetService();
        }

        [WebMethod]
        public Target getById(long id)
        {
            return targetService.getById(id);
        }

        [WebMethod]
        public List<Target> getByExerciseId(long exerciseId)
        {
            return targetService.getByExerciseId(exerciseId);
        }

        [WebMethod]
        public List<Target> getByMuscleId(long muscleId)
        {
            return targetService.getByMuscleId(muscleId);
        }
    }
}

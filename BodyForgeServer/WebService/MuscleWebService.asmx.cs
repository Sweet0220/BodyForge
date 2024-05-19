using BodyForgeServer.Entity;
using BodyForgeServer.Service;
using System.Collections.Generic;
using System.Web.Services;

namespace BodyForgeServer.WebService
{
    /// <summary>
    /// Summary description for MuscleWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MuscleWebService : System.Web.Services.WebService
    {
        private MuscleService muscleService;

        public MuscleWebService()
        {
            muscleService = new MuscleService();
        }

        [WebMethod]
        public Muscle getById(long id)
        {
            return muscleService.getById(id);
        }

        [WebMethod]
        public List<Muscle> getAll()
        {
            return muscleService.getAll();
        }
    }
}

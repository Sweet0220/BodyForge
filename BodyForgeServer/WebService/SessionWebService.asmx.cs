using BodyForgeServer.Entity;
using BodyForgeServer.Service;
using System.Collections.Generic;
using System.Web.Services;

namespace BodyForgeServer.WebService
{
    /// <summary>
    /// Summary description for SessionWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SessionWebService : System.Web.Services.WebService
    {
        private SessionService sessionService;

        public SessionWebService()
        {
            sessionService = new SessionService();
        }

        [WebMethod]
        public Session getById(long id)
        {
            return sessionService.getById(id);
        }

        [WebMethod]
        public List<Session> getByWorkoutId(long workoutId)
        {
            return sessionService.getByWorkoutId(workoutId);
        }

        [WebMethod]
        public void deleteById(long id)
        {
            sessionService.deleteById(id);
        }

        [WebMethod]
        public void update(Session session)
        {
            sessionService.update(session);
        }

        [WebMethod]
        public void add(Session session)
        {
            sessionService.add(session);
        }
    }
}

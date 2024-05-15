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
    /// Summary description for WorkoutWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WorkoutWebService : System.Web.Services.WebService
    {
        private WorkoutService workoutService;

        public WorkoutWebService()
        {
            workoutService = new WorkoutService();
        }

        [WebMethod]
        public Workout getById(long id)
        {
            return workoutService.getById(id);
        }

        [WebMethod]
        public List<Workout> getByUserId(long userId)
        {
            return workoutService.getByUserId(userId);
        }

        [WebMethod]
        public List<Workout> getTemplatesByUserId(long userId)
        {
            return workoutService.getTemplatesByUserId(userId);
        }

        [WebMethod]
        public string addWorkout(Workout workout)
        {
            try
            {
                workoutService.save(workout);
                return "Successfully added workout!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod]
        public string deleteWorkout(long id)
        {
            try
            {
                workoutService.deleteById(id);
                return "Successfully deleted workout!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod]
        public string updateWorkout(Workout workout)
        {
            try
            {
                workoutService.update(workout);
                return "Successfully updated workout!";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}

using BodyForgeServer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForgeServer.Repository
{
    internal interface ISessionRepository
    {
        Session getById(long id);
        List<Session> getByWorkoutId(long workoutId);
        void deleteById(long id);
        void add(Session session);
        void update(Session session);
    }
}

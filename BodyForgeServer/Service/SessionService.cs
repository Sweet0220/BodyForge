using BodyForgeServer.Entity;
using BodyForgeServer.Repository;
using BodyForgeServer.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Service
{
    public class SessionService
    {
        private ISessionRepository sessionRepository;

        public SessionService()
        {
            sessionRepository = new SessionRepositoryImpl();
        }

        public Session getById(long id)
        {
            return sessionRepository.getById(id);
        }

        public List<Session> getByWorkoutId(long workoutId) 
        {
            return sessionRepository.getByWorkoutId(workoutId);
        }

        public void deleteById(long id)
        {
            sessionRepository.deleteById(id);
        }

        public void update(Session session)
        {
            sessionRepository.update(session);
        }

        public void add(Session session)
        {
            sessionRepository.add(session);
        }
    }
}
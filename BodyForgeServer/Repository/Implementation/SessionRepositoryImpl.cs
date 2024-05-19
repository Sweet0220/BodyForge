using BodyForgeServer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Repository.Implementation
{
    public class SessionRepositoryImpl : ISessionRepository
    {
        private BodyForgeContext _context;

        public SessionRepositoryImpl()
        {
            _context = new BodyForgeContext();
        }

        public void add(Session session)
        {
            if (session != null)
            {
                _context.Session.Add(session);
                _context.SaveChanges();
            }
        }

        public void deleteById(long id)
        {
            Session session = _context.Session.FirstOrDefault(s => s.id == id);
            if (session != null)
            {
                _context.Session.Remove(session);
                _context.SaveChanges();
            }
        }

        public Session getById(long id)
        {
            Session session = _context.Session.FirstOrDefault(s => s.id == id);
            if (session == null)
            {
                return null;
            }
            return session;
        }

        public List<Session> getByWorkoutId(long workoutId)
        {
            return _context.Session.Where(s => s.id_workout == workoutId).ToList();
        }

        public void update(Session session)
        {
            Session sessionToUpdate = _context.Session.FirstOrDefault(s => s.id == session.id);
            if (sessionToUpdate != null)
            {
                sessionToUpdate.reps = session.reps;
                sessionToUpdate.type = session.type;
                sessionToUpdate.id_workout = session.id_workout;
                sessionToUpdate.id_exercise = session.id_exercise;
                sessionToUpdate.weight = session.weight;
                _context.SaveChanges();
            }
        }
    }
}
using BodyForgeServer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Repository.Implementation
{
    public class WorkoutRepositoryImpl : IWorkoutRepository
    {
        private BodyForgeContext _context;

        public WorkoutRepositoryImpl()
        {
            _context = new BodyForgeContext();
        }

        public void delete(long id)
        {
            Workout workout = _context.Workout.First(w => w.id == id);
            if (workout != null)
            {
                _context.Workout.Remove(workout);
                _context.SaveChanges();
            }
        }

        public Workout getById(long id)
        {
            Workout workout = _context.Workout.First(w => w.id == id);
            if (workout == null)
            {
                return null;
            }
            return workout;
        }

        public List<Workout> getByUserId(long userId)
        {
            return _context.Workout.Where(w => w.id_user == userId).ToList();
        }

        public List<Workout> getTemplatesByUserId(long userId)
        {
            return _context.Workout.Where(w => w.id_user == userId && w.is_template).ToList();
        }

        public void save(Workout workout)
        {
            if (workout != null)
            {
                _context.Workout.Add(workout);
                _context.SaveChanges();
            }
        }

        public void update(Workout workout)
        {
            Workout w = _context.Workout.First(wo => wo.id == workout.id);
            if (w != null)
            {
                w.name = workout.name;
                w.workout_date = workout.workout_date;
                w.duration = workout.duration;
                w.id_user = workout.id_user;
                w.is_template = workout.is_template;
                _context.SaveChanges();
            }
        }
    }
}
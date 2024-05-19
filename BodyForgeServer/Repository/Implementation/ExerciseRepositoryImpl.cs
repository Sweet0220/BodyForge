using BodyForgeServer.Entity;
using System;
using System.Linq;

namespace BodyForgeServer.Repository.Implementation
{
    public class ExerciseRepositoryImpl : IExerciseRepository
    {
        private BodyForgeContext _context;

        public ExerciseRepositoryImpl()
        {
            _context = new BodyForgeContext();
        }

        public Exercise getById(long id)
        {
            Exercise exercise = _context.Exercise.FirstOrDefault(e => e.id == id);
            if (exercise == null)
            {
                return null;
            }
            return exercise;
        }
    }
}
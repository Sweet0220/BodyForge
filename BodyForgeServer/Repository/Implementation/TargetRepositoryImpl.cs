using BodyForgeServer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Repository.Implementation
{
    public class TargetRepositoryImpl : ITargetRepository
    {
        private BodyForgeContext _context;

        public TargetRepositoryImpl()
        {
            _context = new BodyForgeContext();
        }

        public List<Target> getByExerciseId(long exerciseId)
        {
            return _context.Target.Where(t => t.id_exercise == exerciseId).ToList();
        }

        public Target getById(long id)
        {
            Target target = _context.Target.First(t => t.id == id);
            if (target == null)
            {
                return null;
            }
            return target;
        }

        public List<Target> getByMuscleId(long muscleId)
        {
            return _context.Target.Where(t => t.id_muscle == muscleId).ToList();
        }
    }
}
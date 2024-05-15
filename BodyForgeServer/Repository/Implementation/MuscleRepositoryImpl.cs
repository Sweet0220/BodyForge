using BodyForgeServer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Repository.Implementation
{
    public class MuscleRepositoryImpl : IMuscleRepository
    {
        private BodyForgeContext _context;

        public MuscleRepositoryImpl()
        {
            _context = new BodyForgeContext();
        }

        public Muscle getById(long id)
        {
            Muscle muscle = _context.Muscle.First(m => m.id == id);
            if (muscle == null)
            {
                return null;
            }
            return muscle;
        }
    }
}
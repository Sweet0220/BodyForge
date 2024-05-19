using BodyForgeServer.Entity;
using BodyForgeServer.Repository;
using BodyForgeServer.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Service
{
    public class MuscleService
    {
        private IMuscleRepository muscleRepository;

        public MuscleService()
        {
            muscleRepository = new MuscleRepositoryImpl();
        }

        public Muscle getById(long id)
        {
            return muscleRepository.getById(id);
        }

        public List<Muscle> getAll()
        {
            return muscleRepository.getAll();
        }
    }
}
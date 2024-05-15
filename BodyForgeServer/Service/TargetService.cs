using BodyForgeServer.Entity;
using BodyForgeServer.Repository;
using BodyForgeServer.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Service
{
    public class TargetService
    {
        private ITargetRepository targetRepository;

        public TargetService()
        {
            targetRepository = new TargetRepositoryImpl();
        }

        public Target getById(long id)
        {
            return targetRepository.getById(id);
        }

        public List<Target> getByExerciseId(long exerciseId)
        {
            return targetRepository.getByExerciseId(exerciseId);
        }

        public List<Target> getByMuscleId(long muscleId)
        {
            return targetRepository.getByMuscleId(muscleId);
        }

    }
}
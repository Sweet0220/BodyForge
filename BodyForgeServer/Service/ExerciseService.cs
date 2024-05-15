using BodyForgeServer.Entity;
using BodyForgeServer.Repository;
using BodyForgeServer.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Service
{
    public class ExerciseService
    {
        private IExerciseRepository exerciseRepository;

        public ExerciseService()
        {
            exerciseRepository = new ExerciseRepositoryImpl();
        }

        public Exercise getById(long id)
        {
            Exercise exercise = exerciseRepository.getById(id);
            return exercise;
        }
    }
}
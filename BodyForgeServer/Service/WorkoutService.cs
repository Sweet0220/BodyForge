using BodyForgeServer.Entity;
using BodyForgeServer.Repository;
using BodyForgeServer.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Service
{
    public class WorkoutService
    {
        private IWorkoutRepository workoutRepository;

        public WorkoutService()
        {
            workoutRepository = new WorkoutRepositoryImpl();
        }

        public Workout getById(long id)
        {
            return workoutRepository.getById(id);
        }

        public List<Workout> getByUserId(long userId)
        {
            return workoutRepository.getByUserId(userId);
        }

        public List<Workout> getTemplatesByUserId(long userId)
        {
            return workoutRepository.getTemplatesByUserId(userId);
        }

        public void deleteById(long id)
        {
            workoutRepository.delete(id);
        }

        public void save(Workout workout)
        {
            workoutRepository.save(workout);
        }

        public void update(Workout workout)
        {
            workoutRepository.update(workout);
        }

    }
}
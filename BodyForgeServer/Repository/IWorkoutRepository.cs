using BodyForgeServer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForgeServer.Repository
{
    internal interface IWorkoutRepository
    {
        Workout getById(long id);
        List<Workout> getByUserId(long userId);
        List<Workout> getTemplatesByUserId(long userId);
        void save(Workout workout);
        void delete(long id);
        void update(Workout workout);
    }
}

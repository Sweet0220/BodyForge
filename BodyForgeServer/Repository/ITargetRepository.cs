using BodyForgeServer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForgeServer.Repository
{
    internal interface ITargetRepository
    {
        Target getById(long id);
        List<Target> getByMuscleId(long muscleId);
        List<Target> getByExerciseId(long exerciseId);
    }
}

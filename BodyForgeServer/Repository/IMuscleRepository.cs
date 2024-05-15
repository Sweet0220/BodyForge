using BodyForgeServer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForgeServer.Repository
{
    internal interface IMuscleRepository
    {
        Muscle getById(long id);
    }
}

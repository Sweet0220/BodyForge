using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Entity
{
    public class Target
    {
        public long id { get; set; }
        public long id_muscle { get; set; }
        public long id_exercise {  get; set; }

        public Target()
        {
            
        }
    }
}
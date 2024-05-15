﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Entity
{
    public class Session
    {
        public long id { get; set; }
        public int reps { get; set; }  
        public float weight { get; set; }
        public string type {  get; set; }
        public long id_workout { get; set; }
        public long id_exercise { get; set; }

        public Session()
        {
            
        }
    }
}
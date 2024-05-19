using System;

namespace BodyForgeClient.Entitys
{
    public class Workout
    {
        public long id {  get; set; }
        public string name {  get; set; }
        public DateTime workout_date { get; set; }
        public string duration {  get; set; }
        public long id_user { get; set; }
        public bool is_template {  get; set; }

        public Workout()
        {
            
        }
    }
}
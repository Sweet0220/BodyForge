using BodyForgeClient.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForgeClient.Model
{
    internal static class CurrentUser
    {
        public static long id { get; set; }
        public static string username { get; set; }
        public static string password { get; set; }
        public static string email { get; set; }
    }
}

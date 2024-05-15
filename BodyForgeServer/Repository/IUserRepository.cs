using BodyForgeServer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForgeServer.Repository
{
    internal interface IUserRepository
    {
        Users getUserById(long id);
        Users getUserByUsername(string username);
        void addUser(Users user);
        void deleteById(long id);
    }
}

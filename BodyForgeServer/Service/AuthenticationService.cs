using BodyForgeServer.Entity;
using BodyForgeServer.Repository;
using BodyForgeServer.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Service
{
    public class AuthenticationService
    {
        private IUserRepository userRepository;

        public AuthenticationService()
        {
            userRepository = new UserRepositoryImpl();
        }

        public bool login(string username, string password)
        {
            Users user = userRepository.getUserByUsername(username);
            if (user == null)
            {
                return false;
            }
            if (user.password == password)
            {
                return true;
            }
            return false;
        }
    }
}
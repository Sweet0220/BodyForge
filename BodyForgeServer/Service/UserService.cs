using BodyForgeServer.Entity;
using BodyForgeServer.Repository;
using BodyForgeServer.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Service
{
    public class UserService
    {
        private IUserRepository userRepository;

        public UserService()
        {
            userRepository = new UserRepositoryImpl();
        }

        public Users getById(long id)
        {
            return userRepository.getUserById(id);
        }

        public void addUser(Users user)
        {
            userRepository.addUser(user);
        }

        public void deleteUser(long id)
        {
            userRepository.deleteById(id);
        }
    }
}
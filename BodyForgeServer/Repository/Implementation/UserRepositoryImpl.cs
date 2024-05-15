using BodyForgeServer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BodyForgeServer.Repository.Implementation
{
    public class UserRepositoryImpl : IUserRepository
    {
        BodyForgeContext _context;

        public UserRepositoryImpl()
        {
            _context = new BodyForgeContext();
        }

        public void addUser(Users user)
        {
            if (user != null)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
        }

        public void deleteById(long id)
        {
            Users user = _context.Users.First(u => u.id == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public Users getUserById(long id)
        {
            Users user = _context.Users.First(u => u.id == id);
            if (user == null)
            {
                return null;
            }
            return user;
        }

        public Users getUserByUsername(string username)
        {
            Users user = _context.Users.First(u => u.username == username);
            if (user == null)
            {
                return null;
            }
            return user;
        }
    }
}
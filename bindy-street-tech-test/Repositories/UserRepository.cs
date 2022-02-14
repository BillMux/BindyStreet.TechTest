using BindyStreet.TechTest.Models;
using System;
using System.Collections.Generic;

namespace BindyStreet.TechTest.Repositories
{
    public class UserRepository
    {
        public IEnumerable<User> GetAll()
        {
            var users = new List<User>();

            users.Add(new User()
            {
                Id = Guid.NewGuid()
            });

            return users;
        }
    }
}

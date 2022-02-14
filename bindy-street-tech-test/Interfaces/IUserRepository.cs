using BindyStreet.TechTest.Models;
using System.Collections.Generic;

namespace BindyStreet.TechTest.Interfaces
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAll();
    }
}

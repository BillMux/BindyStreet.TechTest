using BindyStreet.TechTest.Interfaces;
using BindyStreet.TechTest.Models;
using System;
using System.Collections.Generic;

namespace BindyStreet.TechTest.Repositories
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> GetAll()
        {
            var users = new List<User>();

            users.Add(new User()
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Name = "Leanne Graham",
                Username = "Bret",
                Email = "Sincere@april.biz",
                Address = new Address
                {
                    Street = "Kulas Light",
                    Suite = "Apt. 556",
                    City = "Gwenborough",
                    ZipCode = "92998-3874",
                    Geo = new GeographicalCoordinates
                    {
                        Lat = "-37.3159",
                        Lng = "81.1496"
                    }
                },
                Phone = "1-770-736-8031 x56442",
                Website = "hildegard.org",
                Company = new Company
                {

                }
            });

            return users;
        }
    }
}

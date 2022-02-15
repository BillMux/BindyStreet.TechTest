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

            AddMockedData(users);

            return users;
        }

        private static void AddMockedData(List<User> users)
        {
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
                    Name = "Romaguera-Crona",
                    CatchPhrase = "Multi-layered client-server neural-net",
                    BS = "harness real-time e-markets"
                }
            });

            users.Add(new User()
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Name = "Ervin Howell",
                Username = "Antonette",
                Email = "Shanna@melissa.tv",
                Address = new Address
                {
                    Street = "Victor Plains",
                    Suite = "Suite 879",
                    City = "Wisokyburgh",
                    ZipCode = "90566-7771",
                    Geo = new GeographicalCoordinates
                    {
                        Lat = "-43.9509",
                        Lng = "-34.4618"
                    }
                },
                Phone = "010-692-6593 x09125",
                Website = "anastasia.net",
                Company = new Company
                {
                    Name = "Deckow-Crist",
                    CatchPhrase = "Proactive didactic contingency",
                    BS = "synergize scalable supply-chains"
                }
            });

            users.Add(new User()
            {
                Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                Name = "Clementine Bauch",
                Username = "Samantha",
                Email = "Nathan@yesenia.net",
                Address = new Address
                {
                    Street = "Douglas Extension",
                    Suite = "Suite 847",
                    City = "McKenziehaven",
                    ZipCode = "59590-4157",
                    Geo = new GeographicalCoordinates
                    {
                        Lat = "-68.6102",
                        Lng = "-47.0653"
                    }
                },
                Phone = "1-463-123-4447",
                Website = "ramiro.info",
                Company = new Company
                {
                    Name = "Romaguera-Jacobson",
                    CatchPhrase = "Face to face bifurcated interface",
                    BS = "e-enable strategic applications"
                }
            });

            users.Add(new User()
            {
                Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                Name = "Patricia Lebsack",
                Username = "Karianne",
                Email = "Julianne.OConner@kory.org",
                Address = new Address
                {
                    Street = "Hoeger Mall",
                    Suite = "Apt. 692",
                    City = "South Elvis",
                    ZipCode = "53919-4257",
                    Geo = new GeographicalCoordinates
                    {
                        Lat = "29.4572",
                        Lng = "-164.2990"
                    }
                },
                Phone = "493-170-9623 x156",
                Website = "kale.biz",
                Company = new Company
                {
                    Name = "Robel-Corkery",
                    CatchPhrase = "Multi-tiered zero tolerance productivity",
                    BS = "transition cutting-edge web services"
                }
            });

            users.Add(new User()
            {
                Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                Name = "Chelsey Dietrich",
                Username = "Kamren",
                Email = "Lucio_Hettinger@annie.ca",
                Address = new Address
                {
                    Street = "Skiles Walks",
                    Suite = "Suite 351",
                    City = "Roscoeview",
                    ZipCode = "33263",
                    Geo = new GeographicalCoordinates
                    {
                        Lat = "-31.8129",
                        Lng = "62.5342"
                    }
                },
                Phone = "(254)954-1289",
                Website = "demarco.info",
                Company = new Company
                {
                    Name = "Keebler LLC",
                    CatchPhrase = "User-centric fault-tolerant solution",
                    BS = "revolutionize end-to-end systems"
                }
            });

            users.Add(new User()
            {
                Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                Name = "Mrs. Dennis Schulist",
                Username = "Leopoldo_Corkery",
                Email = "Karley_Dach@jasper.info",
                Address = new Address
                {
                    Street = "Norberto Crossing",
                    Suite = "Apt. 950",
                    City = "South Christy",
                    ZipCode = "23505-1337",
                    Geo = new GeographicalCoordinates
                    {
                        Lat = "-71.4197",
                        Lng = "71.7478"
                    }
                },
                Phone = "1-477-935-8478 x6430",
                Website = "ola.org",
                Company = new Company
                {
                    Name = "Considine-Lockman",
                    CatchPhrase = "Synchronised bottom-line interface",
                    BS = "e-enable innovative applications"
                }
            });

            users.Add(new User()
            {
                Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
                Name = "Kurtis Weissnat",
                Username = "Elwyn.Skiles",
                Email = "Telly.Hoeger@billy.biz",
                Address = new Address
                {
                    Street = "Rex Trail",
                    Suite = "Suite 280",
                    City = "Howemouth",
                    ZipCode = "58804-1099",
                    Geo = new GeographicalCoordinates
                    {
                        Lat = "24.8918",
                        Lng = "21.8984"
                    }
                },
                Phone = "210.067.6132",
                Website = "elvis.io",
                Company = new Company
                {
                    Name = "Johns Group",
                    CatchPhrase = "Configurable multimedia task-force",
                    BS = "generate enterprise e-tailers"
                }
            });

            users.Add(new User()
            {
                Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                Name = "Nicholas Runolfsdottir V",
                Username = "Maxime_Nienow",
                Email = "Sherwood@rosamond.me",
                Address = new Address
                {
                    Street = "Ellsworth Summit",
                    Suite = "Suite 729",
                    City = "Aliyaview",
                    ZipCode = "45169",
                    Geo = new GeographicalCoordinates
                    {
                        Lat = "-14.3990",
                        Lng = "-120.7677"
                    }
                },
                Phone = "586.493.6943 x140",
                Website = "jacynthe.com",
                Company = new Company
                {
                    Name = "Abernathy Group",
                    CatchPhrase = "Implemented secondary concept",
                    BS = "e-enable extensible e-tailers"
                }
            });

            users.Add(new User()
            {
                Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
                Name = "Glenna Reichert",
                Username = "Delphine",
                Email = "Chaim_McDermott@dana.io",
                Address = new Address
                {
                    Street = "Dayna Park",
                    Suite = "Suite 449",
                    City = "Bartholomebury",
                    ZipCode = "76495-3109",
                    Geo = new GeographicalCoordinates
                    {
                        Lat = "24.6463",
                        Lng = "-168.8889"
                    }
                },
                Phone = "(775)976-6794 x41206",
                Website = "conrad.com",
                Company = new Company
                {
                    Name = "Yost and Sons",
                    CatchPhrase = "Switchable contextually-based project",
                    BS = "aggregate real-time technologies"
                }
            });

            users.Add(new User()
            {
                Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                Name = "Clementina DuBuque",
                Username = "Moriah.Stanton",
                Email = "Rey.Padberg@karina.biz",
                Address = new Address
                {
                    Street = "Kattie Turnpike",
                    Suite = "Suite 198",
                    City = "Lebsackbury",
                    ZipCode = "31428-2261",
                    Geo = new GeographicalCoordinates
                    {
                        Lat = "-38.2386",
                        Lng = "57.2232"
                    }
                },
                Phone = "024-648-3804",
                Website = "ambrose.net",
                Company = new Company
                {
                    Name = "Hoeger LLC",
                    CatchPhrase = "Centralized empowering task-force",
                    BS = "target end-to-end models"
                }
            });
        }
    }
}

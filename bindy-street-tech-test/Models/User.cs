using System;

namespace BindyStreet.TechTest.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public Address Address { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }

        public Company Company { get; set; }



        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactApp.Models
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public Contact()
        {

        }
    }
}

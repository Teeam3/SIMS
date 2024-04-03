using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }   
        public DateTime BirthDay { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public string EmailAddress {  get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}

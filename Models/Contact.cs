using System.Collections.Generic;
using CommandPatternExample.Enums;

namespace CommandPatternExample.Models
{
    public class Contact
    {
        public string Name { get; set; }

        public List<Address> Addresses { get; set; }

        public List<Phone> Phone { get; set; }

        public ContactType Type { get; set; }
    }
}
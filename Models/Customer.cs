using System.Collections.Generic;
using CommandPatternExample.Interfaces;
using CommandPatternExample.Models;

namespace CommandPatternExample.Models
{

    public class Customer 
    {
        public string Name { get; set; }
        
        public List<Address> Addresses { get; set; } = new List<Address>();

        public List<Phone> Phones { get; set; } = new List<Phone>();

        public List<Contact> Contacts { get; set; }

        public void Action(ICommand command)
        {
            command.Execute();
        }
    }
}
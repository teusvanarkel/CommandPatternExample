using CommandPatternExample.Interfaces;
using CommandPatternExample.Models;

namespace CommandPatternExample.CustomerCommands
{
    public class AddAddressCommand :ICommand
    {
        private Customer _customer;
        private Address _address;
        public AddAddressCommand(Customer customer, Address address)
        {
            _customer = customer;
            _address = address;
        }

        public void Execute()
        {
            _customer.Addresses.Add(_address);
        }
    }
}
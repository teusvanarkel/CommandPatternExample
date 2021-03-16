using CommandPatternExample.Interfaces;
using CommandPatternExample.Models;

namespace CommandPatternExample.CustomerCommands
{
    public class AddPhoneCommand: ICommand
    {
        private Customer _customer;
        private Phone _phone;
        public AddPhoneCommand(Customer customer, Phone phone)
        {
            _customer = customer;
            _phone = phone;
        }

        public void Execute()
        {
            _customer.Phones.Add(_phone);
        }
    }
}
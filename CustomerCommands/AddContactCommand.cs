using CommandPatternExample.Models;

namespace CustomerCommands
{
    public class AddContactCommand
    {
        private Customer _customer;
        private Contact _contact;
        public AddContactCommand(Customer customer,Contact contact)
        {
            _customer = customer;
            _contact = contact;
        }

        public void Execute()
        {
            _customer.Contacts.Add(_contact);
        }
    }
}
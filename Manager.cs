using CommandPatternExample.CustomerCommands;
using CommandPatternExample.Enums;
using CommandPatternExample.Managers;
using CommandPatternExample.Models;

namespace CommandPatternExample
{
    public class Manager
    {
        Customer customer = new Customer(){ Name ="Customer" };
        Address address = new Address(){ Street= "straat", Type = AddressType.Business};
        Phone phone = new Phone(){ Number="123", Type = PhoneType.Home};
        CustomerManager customerManager = new CustomerManager();

        public void AddAddress()
        {
            var addAddressCommand = new AddAddressCommand(customer,address);
            customerManager.SetCommand(addAddressCommand);
            customerManager.ExecuteCommand();
        }

        public void AddPhone()
        {
            var addPhoneCommand = new AddPhoneCommand(customer, phone);
            customerManager.SetCommand(addPhoneCommand);
            customerManager.ExecuteCommand();
        }
    }
}
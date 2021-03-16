using CommandPatternExample.Enums;

namespace CommandPatternExample.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public AddressType Type { get; set; }
    }
}
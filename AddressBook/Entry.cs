using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Entry
    {
        // Constructor
        public Entry(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }

        public string GetAll()
        {
            return $"First Name: {FirstName} \nLast Name: {LastName}" +
                $"\nAddress: {Address} \nEmail: {Email} \n" +
                $"Phone: {Phone.ToString("D11")}";
        }
    }
}

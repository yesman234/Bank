using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{
    public class Customer
    {
        public string CustomerName;
        DateTime DateofBirth;
        string PhoneNumber;
        string Address;

        public Customer(string aCustomerName, DateTime aDateOfBirth, string aPhoneNumber, string aAddress)
        {
            CustomerName = aCustomerName;
            DateofBirth = aDateOfBirth;
            PhoneNumber = aPhoneNumber;
            Address = aAddress;
        }

        void UpdatePhone(string aNewPhone)
        {

        }

        void UpdateAddress(string aNewAddress)
        {

        }
    }
}

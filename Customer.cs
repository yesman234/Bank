using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{
    public class Customer
    {
        public string CustomerName;
        DateTime DateofBirth;
        public string PhoneNumber;
        public string Address;

        public Customer(string aCustomerName, DateTime aDateOfBirth, string aPhoneNumber, string aAddress)
        {
            CustomerName = aCustomerName;
            DateofBirth = aDateOfBirth;
            PhoneNumber = aPhoneNumber;
            Address = aAddress;
        }

        //Copy Construstor
        public Customer(Customer accountCustomer)
        {
            CustomerName = accountCustomer.CustomerName;
            DateofBirth = accountCustomer.DateofBirth;
            PhoneNumber = accountCustomer.PhoneNumber;
            Address = accountCustomer.Address;
        }
    }
}

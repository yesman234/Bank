using System;
using System.Collections.Generic;

namespace BankClassLibrary
{

    public partial class Account
    {
        public string CustomerName;
        DateTime DateofBirth;
        string PhoneNumber;
        string Address;
        void UpdatePhone(string aNewPhone)
        {

        }

        void UpdateAddress(string aNewAddress)
        {

        }

    }
    public partial class Account
    {
        int AccountNumber;
       
        public double CurrentBalance;
        List<double> ListOfTransactions;

        // Initialization
        public Account(string aCustomerName, DateTime aDateOfBirth, string aPhone = null, string aAddress = null )
        {
            CustomerName = aCustomerName;
            DateofBirth = aDateOfBirth;
            PhoneNumber = aPhone;
            Address = aAddress;

            AccountNumber = Guid.NewGuid().GetHashCode();

            CurrentBalance = 0;
            ListOfTransactions = new List<double>();

        }

        // A method to display balance
        void DisplayBalance(double aTest)
        {

        }

        //Deposit money method
        bool DepositMoneyType(double aAmount)
        {
            bool isSuccess = false;

            return isSuccess;
        }

        //Withdraw money method
        bool WithdrawMoneyType(double aAmount)
        {
            bool isSuccess = false;

            return isSuccess;
        }

        public class Transaction
        {

        }
       
    }
}

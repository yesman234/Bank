using System;
using System.Collections.Generic;

namespace BankClassLibrary
{

    public class Account
    {
        #region FEILDS AND PROPERTIES
        public static double ExchangeRate = 1.1d; // Exchange rate to foreign currency
        public const string EMPTY_ADDRESS = "UNKNOWN";
        private const string EMPTY_PHONE = "####";

        Customer AccountCustomer; //Account Holder
        public string CustomerName
        {
            get
            {
                return AccountCustomer.CustomerName;
            }
        }

        public string CustomerPhone
        {
            get
            {
                return AccountCustomer.PhoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    AccountCustomer.PhoneNumber = EMPTY_PHONE;
                }
                else
                {
                    AccountCustomer.PhoneNumber = value;
                }
            }
        }

        public string CustomerAddress
        {
            get
            {
                return AccountCustomer.Address;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    AccountCustomer.Address = EMPTY_ADDRESS;
                }
                else
                {
                    AccountCustomer.Address = value;
                }
                AccountCustomer.Address = value;
            }
        }
        int AccountNumber; //Unique Account Id
       
        public double CurrentBalance;  // The amount of money in the account
        public double Balance
        {
            get
            {
                return CurrentBalance;
            }
        }

        public double BalanceInForeignCurrency
        {
            get
            {
                return CurrentBalance * ExchangeRate;
            }
        }

        List<Transaction> ListOfTransactions;

        public Transaction LastTransaction
        {
            get
            {
                if(ListOfTransactions.Count > 0)
                {
                    return ListOfTransactions[ListOfTransactions.Count - 1];
                }
                else
                {
                    return null;
                }
            }
        }

        #endregion FEILDS AND PROPERTIES

        #region CONSTRUCTORS
        // Initialization
        public Account(string aCustomerName, DateTime aDateOfBirth, string aPhone = null, string aAddress = null )
        {
            AccountCustomer = new Customer(aCustomerName, aDateOfBirth, aPhone, aAddress);
            AccountNumber = Guid.NewGuid().GetHashCode();

            CurrentBalance = 0;
            ListOfTransactions = new List<Transaction>();
        }
        #endregion CONSTRUCTORS

        #region METHODS
        // A method to display balance
        void DisplayBalance()
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
        #endregion METHODS

        #region NESTED TYPES
        public class Transaction
        {
            public double AmountOfTransaction;
            public DateTime TransactionDate;
            public string Location;

            //Transaction type
            public TransactionType TypeOfTransaction;
        }
        public enum TransactionType
        {
            DEPOSIT,
            WITHDRAWL
        }
        #endregion NESTED TYPES
    }
}

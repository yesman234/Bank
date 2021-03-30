using System;
using System.Collections.Generic;

namespace BankClassLibrary
{

    public class Account
    {
        #region FEILDS AND PROPERTIES

        public static double ExchangeRate = 1.1d;

        private const string EMPTY_ADDRESS = "UNKNOWN";

        private const string EMPTY_PHONE = "######";


        Customer AccountCustomer;

        public string CustomerName
        {
            get {
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
                if (String.IsNullOrEmpty(value))
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
                if (String.IsNullOrEmpty(value))
                {
                    AccountCustomer.Address = EMPTY_ADDRESS;
                }
                else
                {
                    AccountCustomer.Address = value;

                }
            }
        }


        int AccountNumber;

        public double CurrentBalance;

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
                return CurrentBalance *ExchangeRate;
            }
        }

        List<Transaction> ListOfTransactions;

        public Transaction LastTransaction
        {
            get
            {
                if (ListOfTransactions.Count > 0)
                {
                    return ListOfTransactions[ListOfTransactions.Count - 1];
                }
                else
                {
                    return null;
                }
            }
        }


        #endregion

        #region CONSTRUCTORS


        public Account()
        {
            AccountCustomer = new Customer("ADMIN", new DateTime(2000,1,1), null, null);

            AccountNumber = Guid.NewGuid().GetHashCode();

            CurrentBalance = 0;

            ListOfTransactions = new List<Transaction>();
        }

        //copy constructor
        public Account(Account aAccountToCopy)
        {
            AccountNumber = aAccountToCopy.AccountNumber;
            CurrentBalance = aAccountToCopy.CurrentBalance;

            ListOfTransactions = new List<Transaction>();

            for (int i = 0 ;i < aAccountToCopy.ListOfTransactions.Count; i++)
            {
                ListOfTransactions.Add(aAccountToCopy.ListOfTransactions[i]);
            }
            //Copy Customer
            AccountCustomer = new Customer(aAccountToCopy.AccountCustomer);
        }

        // Initialization
        public Account(string aCustomerName, DateTime aDateOfBirth, string aPhone = null, string aAddress = null)
        {

            AccountCustomer = new Customer(aCustomerName, aDateOfBirth, aPhone, aAddress);

            AccountNumber = Guid.NewGuid().GetHashCode();

            CurrentBalance = 0;

            ListOfTransactions = new List<Transaction>();
        }
        #endregion

        #region METHODS
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
        #endregion

        #region NESTED TYPES
        public class Transaction
        {
            public double AmountOfTransaction;
            public DateTime TransactionDate;
            public string Location;
            public TransactionType TypeOfTranactions;
        }
        
        public enum TransactionType
        {
            DEPOSIT,
            WITHDRAWL
        }
    }
    #endregion
}

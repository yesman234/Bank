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

            //Deposit money method
            public bool DepositMoney(double aAmount)
            {
                bool isSuccess = false;

            CurrentBalance += aAmount;
            
            Transaction myTransaction = new Transaction (aAmount, TransactionType.DEPOSIT);


            ListOfTransactions.Add(myTransaction);

                return isSuccess;
            }

            //Withdraw money method
            public bool WithdrawMoney(double aAmount)
            {

            bool isSuccess = false;
            CurrentBalance -= aAmount;
            Transaction myTransaction = new Transaction(aAmount, TransactionType.WITHDRAWAL);


            ListOfTransactions.Add(myTransaction);



            return isSuccess;
            }


        //Display Balance
        public void DisplayBalance()
        {
            Console.WriteLine("Display Balance " + CurrentBalance);
        }

        #endregion METHODS

        // create  a method to show the transInfo

        #region NESTED TYPES
        public class Transaction
        {
            #region FEILDS AND PROPERTIES
             double AmountOfTransaction;
             DateTime TransactionDate;
             string Location;

            TransactionType TypeOfTransaction;

            public double MoneyAmount
            {
                get
                {
                    return AmountOfTransaction;
                }
                set
                {
                    AmountOfTransaction = value;
                }
            }
            #endregion

            #region METHODS
            public void DisplayTransaction()
            {
                Console.WriteLine((TypeOfTransaction == TransactionType.DEPOSIT ? "Deposit" : "Withdraw") + " is done.");
                Console.WriteLine("Total Amount" + AmountOfTransaction + "Date:" + TransactionDate.ToString("yyyy/mm/dd"));
            }

            #endregion
            #region CONSTRUCTORS

            private Transaction()
            {
                //cannot be called

            }
            public Transaction(double aAmountOfTransaction, TransactionType aTransactionType)
            {
                AmountOfTransaction = aAmountOfTransaction;
                TypeOfTransaction = aTransactionType; 

                TransactionDate = DateTime.Now;
                Location = "EARTH";
            }

            public Transaction(Transaction aTransactionToCopy)
            {
                AmountOfTransaction = aTransactionToCopy.AmountOfTransaction;
                TypeOfTransaction = aTransactionToCopy.TypeOfTransaction;
                TransactionDate = aTransactionToCopy.TransactionDate;
                Location = aTransactionToCopy.Location;
            }
            #endregion
        }

        //Transaction Type
        public enum TransactionType
        {
            DEPOSIT,
            WITHDRAWAL
        }
    }
    #endregion
}

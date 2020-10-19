/*#############################################################################################
 Name: Abigail Herron
 ID: s00200536
 Date: 19/10/20

 Description: Basic bank account
 Properties: AccountNumber, AccountHolder, Balance
 Methods: Deposit(), Withdraw(), ToString() (replaces original ToString())
 Constructors: 1) BankAccount() (none - default)
               2) BankAccount(AccountNumber, AccountHolder, Balance) (all)
 #############################################################################################*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Labsheet4
{
    class BankAccount
    {
        /* Declaring Properties ----------------------------------------------*/
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }





        /* Declaring Methods -------------------------------------------------*/

        /*---------
         Method: Deposit()
            1) Takes a double value
            2) Adds that value to the Balance property of the object
        ---------*/
        public void Deposit(double ammount)
        {
            this.Balance += ammount;
        }// end Deposit()



        /*---------
         Method: Withdraw()
            1) Takes a double value
            2) Removes that ammount from the Balance property of the object
        ---------*/
        public void Withdraw(double ammount)
        {
            this.Balance -= ammount;
        }// end Withdraw()



        /*---------
        Method: ToString()
                1) Overrides the ToString() method
                2) Prints the AccountNumber, AccountHolder and Balance 
                   properties to the screen on different lines
        ---------*/
        public override string ToString()
        {
            return
                string.Format($"Account Number: {AccountNumber}" +
                              $"\nAccount Holder: {AccountHolder}" +
                              $"\nBalance: {Balance}");
        }// end new ToString()




        /* Declaring Constructors --------------------------------------------*/
        public BankAccount()
        {
            this.AccountNumber = 0;
            this.AccountHolder = "?";
            this.Balance = 0;
        }// end Default Constructor


        public BankAccount(int acc, string hold, double bal)
        {
            this.AccountNumber = acc;
            this.AccountHolder = hold;
            this.Balance = bal;
        }// end All Constructor

    }// end BankAccount Class
}// end Namespace

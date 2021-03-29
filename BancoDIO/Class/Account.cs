using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDIO.Account
{
    class Account{
        private string Name { get; set; }

        private AccountType AccountType { get; set; }

        private double Balance { get; set; }

        private double Credit { get; set; }


        public Account(string name, AccountType accountType, double balance, double credit){
            this.Name = name;

            this.AccountType = accountType;

            this.Balance = balance;

            this.Credit = credit;
        }

        public bool Withdraw(double withdrawvalue){
            if(this.Balance - withdrawvalue >= 0 && withdrawvalue > 0){
                this.Balance -= withdrawvalue;
            }
            else{
                Console.WriteLine("insufficient funds!!!");
                Console.WriteLine("TRY AGAIN WITH ANOTHER VALUE");
                return false;
            }
            Console.WriteLine(this.Name + " your current balance is : " + this.Balance);

            return true;
        }

        public void Deposit(double depositvalue){
            if (depositvalue > 0){

                this.Balance += depositvalue;
            }
            else{
                Console.WriteLine("ERROR!!!");
                Console.WriteLine("TRY AGAIN WITH ANOTHER VALUE");
                
            }
            Console.WriteLine(this.Name + " your current balance is : " + this.Balance);
            
        }

        public void Transfer(double transfervalue, Account destinationaccount ){
            if (transfervalue > 0 && this.Balance - transfervalue >= 0){
                destinationaccount.Deposit(transfervalue);
                this.Balance -= transfervalue;
            }
            else
            {
                Console.WriteLine("insufficient funds!!!");
                Console.WriteLine("TRY AGAIN WITH ANOTHER VALUE");
            }
            Console.WriteLine(this.Name + " your current balance is : " + this.Balance);
        }

        public override string ToString()
        {   string return1 = "";
            return1 += "/// Name : " + this.Name + " ///";
            return1 += " Account type : " + this.AccountType + " ///";
            return1 += " Balance : " + this.Balance + " ///";
            return1 += " Credit : " + this.Credit + " ///";
            return return1;
        }

    }
}

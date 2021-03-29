using System;
using System.Collections.Generic;

namespace BancoDIO.Account
{
    class Program
    {
        public static List<Account> accountlist = new List<Account>();

        static void Main(string[] args){
            string UserOption = GetUserOption();

            while (UserOption.ToUpper() != "7"){
                switch (UserOption) {
                    case "1":
                        LISTACCOUNTS();
                        break;
                    case "2":
                        INSERTACCOUNT();
                        break;
                    case "3":
                        TRANSFER();
                        break;
                    case "4":
                        WITHDRAW();
                        break;
                    case "5":
                        DEPOSIT();
                        break;
                    case "6":
                        CLEAR();
                        break;

                    default:
                        throw new ArgumentException();
                }
                UserOption = GetUserOption();
            }
            Console.WriteLine("THANK YOU!!! And see you soon.");
            Console.ReadLine();
        }


        private static string GetUserOption(){
            Console.WriteLine();
            Console.WriteLine("Welcome to DioBank.");
            Console.WriteLine("Select options below.");
            Console.WriteLine();
            Console.WriteLine("1-LIST ACCOUNTS.");
            Console.WriteLine("-----------------------");
            Console.WriteLine("2-INSERT NEW ACCOUNT.");
            Console.WriteLine("-----------------------");
            Console.WriteLine("3-TRANSFER TO ANOTHER ACCOUNT.");
            Console.WriteLine("-----------------------");
            Console.WriteLine("4-TO WITHDRAW.");
            Console.WriteLine("-----------------------");
            Console.WriteLine("5-DEPOSIT.");
            Console.WriteLine("-----------------------");
            Console.WriteLine("6-CLEAR SCREEN.");
            Console.WriteLine("-----------------------");
            Console.WriteLine("7-EXIT");
            string UserOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return UserOption;
        }
        public static void INSERTACCOUNT()
        {

            Console.WriteLine("Insert new account :");
            Console.WriteLine("||||||||||||||||||");
            Console.WriteLine("Type :");
            Console.WriteLine("The new account name");
            string NameEntry = Console.ReadLine();

            Console.WriteLine("||||||||||||||||||");
            Console.WriteLine("Type :");
            Console.WriteLine("0 - physicalperson");
            Console.WriteLine("1 - physicalpersonVIP");
            Console.WriteLine("2 - legalperson");
            Console.WriteLine("3 - legalpersonVIP");
            int AccounTypeEntry = int.Parse(Console.ReadLine());

            Console.WriteLine("||||||||||||||||||");
            Console.WriteLine("Type :");
            Console.WriteLine("The new account balance");
            double BalanceEntry = double.Parse(Console.ReadLine());

            Console.WriteLine("||||||||||||||||||");
            Console.WriteLine("Type :");
            Console.WriteLine("The new account credit");
            double CreditEntry = double.Parse(Console.ReadLine());

            Account NewAccount = new Account(NameEntry,
                                             (AccountType)AccounTypeEntry,
                                             BalanceEntry,
                                             CreditEntry);


            accountlist.Add(NewAccount);
            Console.WriteLine("ADD");

        }

        public static void LISTACCOUNTS()
        {
            Console.WriteLine("List Accounts :");
            if (accountlist.Count == 0)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            Account account;
            for (int i = 0; i < accountlist.Count; i++)
            {
                account = accountlist[i];
                Console.WriteLine(i + " Account : " + account);


            }
        }
        public static void TRANSFER()
        {
            Console.WriteLine("Enter your account number : ");
            int AccountIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another account number : ");
            int AnotherAccountIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the transfer value : ");
            int TranferValue = int.Parse(Console.ReadLine());

            accountlist[AccountIndex].Transfer(TranferValue, accountlist[AnotherAccountIndex]);
        }

        public static void WITHDRAW()
        {
            Console.WriteLine("Enter your account number : ");
            int AccountIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the withdrawal amount : ");
            int WithdrawalAmount = int.Parse(Console.ReadLine());

            accountlist[AccountIndex].Withdraw(WithdrawalAmount);

        }
        public static void DEPOSIT()
        {
            Console.WriteLine("Enter your account number : ");
            int AccountIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the deposit amount : ");
            int DepositAmount = int.Parse(Console.ReadLine());

            accountlist[AccountIndex].Deposit(DepositAmount);
        }

        public static void CLEAR()
        {
            Console.Clear();
            Console.WriteLine("-- interface cleared successfully --");
        }

    }
}

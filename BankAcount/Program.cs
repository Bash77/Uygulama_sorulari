using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    internal class Program
    {
        class bankAcount
        {
            public string AccountNumber { get; private set; }
            public decimal Balance { get; private set; }
            public string OwnerName { get; private set; }
            public bankAcount(string accountNumber, decimal initialBalance, string ownerName)
            {
                AccountNumber = accountNumber;
                Balance = initialBalance;
                OwnerName = ownerName;
            }
            public void Deposit(decimal amount)
            {
                if(amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine("Deopisted  " + amount + "New Balance: " + Balance);
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount.");
                }
            }
            public  void WithDraw(decimal amount)
            {
                if(amount > 0 && Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine("WithDrew " + amount + " New balance " + Balance);

                }
                else
                {
                    Console.WriteLine("Insufficient funds or Invalid withdrewal amount.");
                }
            }
            public void DisplayAmountInfo()
            {
                Console.WriteLine("Acount number: " + AccountNumber);
                Console.WriteLine("Owner Name: " + OwnerName);
                Console.WriteLine("Balance: " + Balance);
        }

        }

       
        static void Main(string[] args)
        {
            bankAcount account = new bankAcount("123456789", 500.00m,  "Bashka");

            // Display initial account information
            account.DisplayAmountInfo();

            // Deposit $200
            account.Deposit(200.00m);

            // Withdraw $150
            account.WithDraw(150.00m);

            // Display updated account information
            account.DisplayAmountInfo();

            Console.ReadKey();
        }
    }
}

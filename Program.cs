using System;
using ExceptionTreatment.Entities;
using ExceptionTreatment.Entities.Exceptions;

namespace ExceptionTreatment
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating account
            Console.WriteLine("Enter account data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account acc = new Account(number, holder, balance, withdrawLimit);
            Console.WriteLine();

            //Withdraw
            Console.Write("Enter amount for withdraw: ");
            try
            {
                double withdraw = double.Parse(Console.ReadLine());
                acc.Withdraw(withdraw);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2"));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}

using System;

namespace BankConsole51
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank bank = new Bank();

            try
            {
                string bankName = args[0];
                bank.Name = bankName;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please supply a name!");
                return;
            }
 
            Console.WriteLine($"Welcome to {bank.Name}'s Management System");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1 - Exit");
            Console.WriteLine("2 - Add an Account");

            Console.Write("> ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                return;
            }
            else if (input == "2")
            {
                bank.AddAccount();
            }
            else
            {
                return;
            }

        }
    }
}

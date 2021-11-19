using System;
using System.Collections.Generic;

namespace BankConsole51
{
    public class Bank
    {
        public string Name {get;set;}

        public List<Account> Accounts {get;set;}

        //5. Add a method to add an account to the list of accounts (ask the user to provide First Name, LastName,
        //and address properties)
        public void AddAccount()
        {
            string firstName = Prompt("First Name: ");
            string lastName = Prompt("Last Name: ");
            string email = Prompt("Email: ");
            string street = Prompt("street: ");
            string apt = Prompt("apt: ");
            string city = Prompt("city: ");
            string state = Prompt("state: ");
            string zip = Prompt("zip: ");

            Account newAccount = new Account
            {
                AccountOwner = new Customer
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Address = new Address
                    {
                        Street = street,
                        Apt = apt,
                        City = city,
                        State = state,
                        Zip = zip
                    }
                },
                Transactions = new List<Transaction>()

            };
            
        }

        public string Prompt(string promptText)
        {
            Console.Write(promptText);
            string response = Console.ReadLine();
            Console.WriteLine();
            return response;
        }

        //6. Add a method to print out the details of all accounts in the bank

        //7. Add a method to accept user input of an account name or account number and print the account details

        //8. Add a method to add a transaction to an account

        //9. Add a method to print mailing labels for each account
    }
}
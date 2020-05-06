using System;

namespace _06_ByteBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CurrentAccount account = new CurrentAccount();
            Customer customer = new Customer();

            customer.Name = "Scarlett Johansson";
            customer.CPF = "464.821.703-21";
            customer.Profession = "Actress";

            // Cannot change the opening account balance to a negative balance
            account.BankBalance = -10;
            account.Holder = customer;

            Console.WriteLine("Name: " + account.Holder.Name);
            Console.WriteLine("CPF: " + account.Holder.CPF);
            Console.WriteLine("Profession: " + account.Holder.Profession);
            Console.WriteLine("Bank balance: " + account.BankBalance);
            Console.ReadLine();
        }
    }
}

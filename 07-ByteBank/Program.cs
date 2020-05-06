using System;

namespace _07_ByteBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Total accounts created: " + CurrentAccount.TotalAccountsCreated);

            Console.WriteLine("\nCreating the first account...");
            CurrentAccount firstAccount = new CurrentAccount(867, 86712540);
            Console.WriteLine("Agency number: " + firstAccount.AgencyNumber);
            Console.WriteLine("Account number: " + firstAccount.accountNumber);
            Console.WriteLine("\nTotal accounts created: " + CurrentAccount.TotalAccountsCreated);

            Console.WriteLine("\nCreating the second account...");
            CurrentAccount secondAccount = new CurrentAccount(867, 86745820);
            Console.WriteLine("Agency number: " + secondAccount.AgencyNumber);
            Console.WriteLine("Account number: " + secondAccount.accountNumber);
            Console.WriteLine("\nTotal accounts created: " + CurrentAccount.TotalAccountsCreated);

            Console.ReadLine();
        }
    }
}

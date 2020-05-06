using System;

namespace _03_ByteBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CurrentAccount firstAccount = new CurrentAccount();
            firstAccount.holder = "Marina Ruy Barbosa";
            firstAccount.agencyNumber = 863;
            firstAccount.accountNumber = 863452;

            CurrentAccount secondAccount = new CurrentAccount();
            secondAccount.holder = "Marina Ruy Barbosa";
            secondAccount.agencyNumber = 863;
            secondAccount.accountNumber = 863452;

            Console.WriteLine("Reference type equality: [first account x second account] = " + (firstAccount == secondAccount));

            int age = 27;
            int anotherAge = 27;

            Console.WriteLine("Value type equality: [age x anotherAge] = " + (age == anotherAge));

            firstAccount = secondAccount;
            Console.WriteLine("Reference type equality: [first account = second account] = " + (firstAccount == secondAccount));

            firstAccount.bankBalance = 300;
            Console.WriteLine("The " + firstAccount.holder + " bank balance is R$ " + firstAccount.bankBalance);
            Console.WriteLine("The " + secondAccount.holder + " bank balance is R$ " + secondAccount.bankBalance);

            Console.ReadLine();
        }
    }
}

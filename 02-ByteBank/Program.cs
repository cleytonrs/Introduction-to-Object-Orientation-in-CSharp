using System;

namespace _02_ByteBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CurrentAccount account = new CurrentAccount();

            account.holder = "Angelina Jolie";

            Console.WriteLine("Holder: " + account.holder);
            Console.WriteLine("Bank balance: R$ " + account.bankBalance);
            Console.ReadLine();
        }
    }
}

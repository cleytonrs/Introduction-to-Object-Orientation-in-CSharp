using System;

namespace _01_ByteBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CurrentAccount firstAccount = new CurrentAccount();
            firstAccount.holder = "Juliana Paes";
            firstAccount.agencyNumber = 863;
            firstAccount.accountNumber = 863452;
            firstAccount.bankBalance = 450000;

            Console.WriteLine("Holder: " + firstAccount.holder);
            Console.WriteLine("Agency number: " + firstAccount.agencyNumber);
            Console.WriteLine("Account number: " + firstAccount.accountNumber);
            Console.WriteLine("Bank balance: R$ " + firstAccount.bankBalance);

            firstAccount.bankBalance += 200;

            Console.WriteLine("Balance after deposit of R$ 200,00: R$ " + firstAccount.bankBalance);

            Console.ReadLine();
        }
    }
}

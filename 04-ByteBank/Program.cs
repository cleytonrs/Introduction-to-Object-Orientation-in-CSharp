using System;

namespace _04_ByteBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CurrentAccount firstAccount = new CurrentAccount();

            firstAccount.holder = "Isis Valverde";

            Console.WriteLine(firstAccount.holder + ", your initial balance is R$ " + firstAccount.bankBalance);

            bool resultAfterWithdrawal = firstAccount.WithdrawalAmount(500);

            Console.WriteLine("Is it possible to withdraw R$ 500? " + resultAfterWithdrawal);
            Console.WriteLine("Your balance is R$ " + firstAccount.bankBalance);

            firstAccount.BankDeposit(500);
            Console.WriteLine("\nBalance after deposit of R$ 500 : " + firstAccount.bankBalance + "\n");

            CurrentAccount secondAccount = new CurrentAccount();
            secondAccount.holder = "Deborah Secco";

            Console.WriteLine(firstAccount.holder + " account balance: R$ " + firstAccount.bankBalance);
            Console.WriteLine(secondAccount.holder + " account balance: R$ " + secondAccount.bankBalance);

            bool transferResult = firstAccount.BankTransfer(200, secondAccount);
            Console.WriteLine("\nTransferring R$ 200 from firstAccount to secondAccount...\n");

            Console.WriteLine(firstAccount.holder + " account balance: R$ " + firstAccount.bankBalance);
            Console.WriteLine(secondAccount.holder + " account balance: R$ " + secondAccount.bankBalance);

            Console.WriteLine("Transfer result: " + transferResult);

            Console.ReadLine();
        }
    }
}

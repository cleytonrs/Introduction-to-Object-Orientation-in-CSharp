using System;

namespace _05_ByteBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CurrentAccount firstAccount = new CurrentAccount();

            firstAccount.Holder = new Customer();
            firstAccount.Holder.name = "Margot Robbie";
            firstAccount.Holder.cpf = "424.569.871-20";
            firstAccount.Holder.profession = "Actress";

            firstAccount.bankBalance = 750000;
            firstAccount.agencyNumber = 563;
            firstAccount.accountNumber = 5634527;

            if (firstAccount.Holder == null)
            {
                Console.WriteLine("The reference for the firstAccount.Holder is NULL");
            }

            Console.WriteLine("Name: " + firstAccount.Holder.name);
            Console.WriteLine("CPF: " + firstAccount.Holder.cpf);
            Console.WriteLine("Profession: " + firstAccount.Holder.profession);
            Console.ReadLine();
        }
    }
}

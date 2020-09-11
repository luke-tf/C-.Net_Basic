using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Lucas",10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with R${account.Balance},00 initial balance.");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            account.MakeWithdrawal(50, DateTime.Now, "Xbox game");

            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine($"Saldo: R${account.Balance},00");

            // try
            // {
            //     var invalidAccount = new BankAccount("invalid", -55);
            // }
            // catch (ArgumentOutOfRangeException e)
            // {
            //     Console.WriteLine("Exception caught creating account with negative balance");
            //     Console.WriteLine(e.ToString());
            // }
        }
    }
}

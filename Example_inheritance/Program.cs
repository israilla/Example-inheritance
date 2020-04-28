using System;
using Example_inheritance.Entities;
namespace Example_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100, 500);

            Console.WriteLine(account.Balance);

            /* using protected method 
            account.Balance = 200; */
        }
    }
}

﻿using System;
using Example_inheritance.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Example_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500, 0.01));
            list.Add(new BusinessAccount(1002,"Maria", 500, 400));
            list.Add(new SavingsAccount(1003, "Bob", 500, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500, 500));

            double sum = 0.0;
            foreach(Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum);

            foreach (Account acc in list)
            {
                acc.Withraw(10);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account"
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture)
                    );
            }
        }
    }
}

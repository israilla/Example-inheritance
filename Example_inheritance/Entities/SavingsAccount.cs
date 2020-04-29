using System;
using System.Collections.Generic;
using System.Text;

namespace Example_inheritance.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withraw(double amount)
        {
            base.Withraw(amount);
            Balance -= 2.0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    class Wallet
    {
        private double Balance { get; set; }

        public void AddCash(double AddToBalance)
        {
            Balance = Balance + AddToBalance;
        }
        public string WithdrawCash(double WithdrawFromBalance)
        {
            Balance = Balance - WithdrawFromBalance;

            if (Balance < 10)
                return "Negative";
            else
                return "Positive";

        }
        public double CashCheck()
        {
            return this.Balance;

        }

    }
}

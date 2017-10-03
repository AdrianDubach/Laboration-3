using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    class Player
    {
       
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        private string Status { get; set; }
        public Wallet PlayerWallet = new Wallet();
        public Player() { }
        public Player(int age)
        { Age = age; }
        public Player(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }
       
        public void AddCash(double cashIncrease)
        {
            PlayerWallet.AddCash(cashIncrease);
            Console.WriteLine(cashIncrease + " added to balance.");
        }
        public void WithdrawCash(double cashDecrease)
        {
            Console.WriteLine(cashDecrease + " withdrawn from balance.");
            Status = PlayerWallet.WithdrawCash(cashDecrease);
            //return Status;
        }
    }
}

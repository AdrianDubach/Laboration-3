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
        public Wallet PlayerWallet;
        //Denna konstruktor kan användas ifall endast age behövs utvinnas. Detta har jag använt för min funktion som kollar olovlig ålder.
        public Player(int age)
        {
            Age = age;
        }
        //Denna konstruktor är den som används för att skapa ett Player objekt med all vital information. Konstruktorn skapar även ett Wallet objekt som kallas PlayerWallet.
        public Player(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
            PlayerWallet = new Wallet();
        }
       //En metod som sätter in sitt parametervärde nämnt cashIncrease som argument i en metod som finns i Wallet objektet. Detta resulterar i att valuta sätts in på kontot.  
        public void AddCash(double cashIncrease)
        {
            PlayerWallet.AddCash(cashIncrease);
            Console.WriteLine("{0:N2}", cashIncrease + " added to balance.");
        }
        //En metod som sätter in sitt parametervärde nämnt cashDecrease som argument i en metod som finns i Wallet objektet. Detta resulterar i att valuta dras ifrån på kontot. 
        public void WithdrawCash(double cashDecrease)
        {
            PlayerWallet.WithdrawCash(cashDecrease);
            Console.WriteLine("{0:f2}", cashDecrease + " withdrawn from balance.");
        }
    }
}

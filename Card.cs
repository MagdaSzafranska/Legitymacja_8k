using System;
using System.Collections.Generic;
using System.Text;

namespace Legitymacja_8k
{
    public class Card
    {
        private static int cardNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public void RegisterNewTrace(decimal kilometers, DateTime date, string note) {}

        // konstruktor - wywoływany podczas tworzenia nowego obiektu klasy
        public Card(string owner)
        {
            this.Owner = owner;
            this.Number = cardNumberSeed.ToString();
            cardNumberSeed++;
        }
    }
}

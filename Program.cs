using System;

namespace Legitymacja_8k
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new Card("Magda");
            Console.WriteLine($"Card {card.Number} was created for {card.Owner}.");
            var card2 = new Card("Wojtek");
            Console.WriteLine($"Card {card2.Number} was created for {card2.Owner}.");
        }
    }
}

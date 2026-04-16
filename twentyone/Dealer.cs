using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace twentyone
{
    public class Dealer
    {
        public string Name { get; set; }

        public int Balance { get; set; }
        public Deck Deck { get; set; }
        public void Deal(List<Card> Hand) 
        {
            Hand.Add(Deck.Cards.First());
            string card=string.Format(Deck.Cards.First().ToString()+"\n");
            Console.WriteLine(card + "\n");
            using (StreamWriter file =new StreamWriter(@"C:\Users\frond\OneDrive\Documents\GitHub\Tech-Academy-Basic-C-sharp-Project\logs.txt", true))
            {
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);

        }


    }
}

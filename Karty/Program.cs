using System.ComponentModel.DataAnnotations;

namespace Karty
{
    internal class Program
    {
        class Card
        {
            public string name { get; private set; }
            public string color { get; private set; }
            public string value { get; private set; }
            
            public Card(string  name, string color, string value)
            {
                this.name = name;
                this.color = color;
                this.value = value;
            }

            public override string ToString()
            {
                return ${name} {color}, wartość {value};
            }
        }
        class Deck
        {
            private ListCard cardsOrginal = new ListCard();
            private ListCard cards = new ListCard();
            public Deck() {
                using (TextReader r = File.OpenText(deck.txt))
                {
                    string linia;
                    while (r.Peek()  -1)
                    {
                        linia = r.ReadLine();
                        string[] karta = linia.Split(;);
                        Card tmp = new Card(karta[0], karta[1], karta[2]);
                        cardsOrginal.Add(tmp);
                        cards.Add(tmp);
                        Console.WriteLine(tmp);
                    }
                }

            }
            public void NewGame()
            {
                cards.Clear();
                private ListCard cardsTemp = new ListCard(cardsOrginal);
                Random r = new Random();
                while(cardsTemp.count  0)
                {
                }
        }
        
        }


        static void Main(string[] args)
        {
            Deck deck = new Deck();
        }
    }
}

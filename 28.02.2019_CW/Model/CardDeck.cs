using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02._2019_CW.Model
{
    public abstract class CardDeck
    {
        protected List<Card> Cards;

        public virtual void Creat()
        {
            foreach (Mast m in (Mast[])Enum.GetValues(typeof(Mast)))
            {
                foreach (Nominal n in (Nominal[])Enum.GetValues(typeof(Nominal)))
                {
                    Cards.Add(new Card() { mast = m, nominal = n });
                }
            }
        }
        public virtual void Shuffle()
        {
            Random rnd = new Random();
            Cards.OrderBy(x => rnd.NextDouble()).ToList();
        }

        public void Print()
        {
            foreach (Card item in Cards)
            {
                Console.WriteLine("{0}, {1}", item.nominal, item.mast);
            }
        }
    }

    
}

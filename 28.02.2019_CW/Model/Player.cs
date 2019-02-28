using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02._2019_CW.Model
{
    public class Player
    {
        public Player()
        {
            Pcards = new Stack<Card>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public Stack<Card> Pcards;

        public void PrintInfo()
        {
            Console.WriteLine("->{0}",Name);
        }
        
        
    }
}

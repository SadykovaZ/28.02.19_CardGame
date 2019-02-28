using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02._2019_CW.Model
{
    public class Game : CardDeck
    {
        public Game()
        {
            base.Cards = new List<Card>();
            base.Creat();
        }
        public List<Player> players;

        public void CreatePlayers(int count = 2)
        {
            if (count < 2)
                throw new Exception("Количество игроков не должно быть меньше двух");

            players = new List<Player>();
            for (int i = 0; i < count; i++)
            {
                Player pl = new Player();
                pl.Id = i;
                pl.Name = "Player " + i;
                players.Add(pl);
            }

        }
        public void Razdacha()
        {
            int p = players.Count-1;
            int k = 0;
            foreach (Card item in Cards)
            {
                if (k > p) k = 0;
                players[k++].Pcards.Push(item);
            }
        }

        public Player StartGame()
        {
            CreatePlayers();
            Shuffle();
            Razdacha();
            Player winner = null;
            int MaxCard = 0;
            Dictionary<Player, Card> dic = new Dictionary<Player, Card>();
            while (!players.Any(x => x.Pcards.Count == 36))
            {

                foreach (Player item in players)
                {
                    item.Pcards.Peek().PrintInfo();
                    dic.Add(item, item.Pcards.Pop());
                    
                }
                Console.WriteLine("");
                foreach (var item in dic)
                {
                    if ((int)item.Value.nominal > MaxCard)
                    {
                        MaxCard = (int)item.Value.nominal;
                        winner = item.Key;

                    }
                }
                winner.PrintInfo();
                foreach (var item in dic)
                {
                    players[winner.Id].Pcards.Push(item.Value);
                }

                winner = null;
                MaxCard = 0;
                dic = new Dictionary<Player, Card>();
            }
            return players.FirstOrDefault(x=>x.Pcards.Count==36);
        }
    }
}

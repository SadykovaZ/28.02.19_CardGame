using _28._02._2019_CW.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02._2019_CW
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //int x = 44;
            //ArrayList array = new ArrayList();
            //array.Add(x);//упаковка

            //int y = (int)array[0];//распаковка

            //List<int> vs = new List<int>();
            //vs.Add(x);

            Game g = new Game();
            Console.WriteLine("Winner: ");
            g.StartGame().PrintInfo();



        }
    }
}

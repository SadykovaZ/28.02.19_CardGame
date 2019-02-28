using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02._2019_CW.Model
{
    public enum Mast { chervi,kresti,bubi,piki}
    public enum Nominal { six=6,seven=7,eight=8,nine=9,ten=10,valet=11,dama=12,korol=13,tuz=14}
    public class Card
    {
        public Mast mast { get; set; }
        public Nominal nominal { get; set; }

        public void PrintInfo()
        {
            Console.Write("{0}-{1} \n", nominal,mast);
        }

    }
}

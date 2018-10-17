using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    abstract class Lenktynininkas
    {
        abstract protected void Vaziuoti(int km, double kuroDaugiklis);
        abstract public double LikutisProc();
        abstract public int LikutisKm();
        abstract protected double Daugiklis(int km);
        public void Lenktyniauti(int km)
        {
            Vaziuoti(km, Daugiklis(km));
            Console.WriteLine("Pralenktyniavo {0} km", km);
            Console.WriteLine("Liko {0}% bako", LikutisProc());
            Console.WriteLine("Dar galima nuvaziuoti {0}km", LikutisKm());
            Console.WriteLine("");
        }
    }
}

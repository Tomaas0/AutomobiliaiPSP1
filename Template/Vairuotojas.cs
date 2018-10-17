using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Vairuotojas
    {
        protected abstract void Vaziuoti(int km, double kuroDaugiklis);
        public abstract double LikutisProc();
        public abstract int LikutisKm();
        public void Vairuoti(int km)
        {
            Vaziuoti(km, 1);
            Console.WriteLine("Pravaziavo {0} km", km);
            Console.WriteLine("Liko {0}% bako", LikutisProc());
            Console.WriteLine("Dar galima nuvaziuoti {0}km", LikutisKm());
            Console.WriteLine("");
        }
    }
}

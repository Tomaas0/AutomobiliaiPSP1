using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    abstract class Lenktynininkas
    {
        abstract protected double Daugiklis { get; }
        abstract protected void Vaziuoti(int km, double kuroDaugiklis);
        abstract public double LikutisProc();
        abstract public int LikutisKm();
        public void Lenktyniauti(int km)
        {
            Vaziuoti(km, Daugiklis);
        }
    }
}

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
        }
    }
}

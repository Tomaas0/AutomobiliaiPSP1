using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliaiPSP1
{
    class ElektrinisAutomobilis : IAutomobilis
    {
        public int Rida { get; set; }
        int MaxKmLikutis { get; set; }
        int KmLikutis { get; set; }
        public ElektrinisAutomobilis(int MaxKmLikutis = 700)
        {
            Rida = 0;
            this.MaxKmLikutis = MaxKmLikutis;
            this.KmLikutis = MaxKmLikutis;
        }

        public void Vaziuoti(int km, double daugiklis = 1)
        {
            int kiekReikiaDegalu = Int32.Parse((km * daugiklis).ToString("0"));
            if (kiekReikiaDegalu < KmLikutis)
            {
                KmLikutis -= kiekReikiaDegalu;
                Rida += km;
            }
        }
        public double LikutisProc()
        {
            double proc = (double)KmLikutis / (double)MaxKmLikutis * 100;
            return proc;
        }
        public int LikutisKm()
        {
            return KmLikutis;
        }
    }
}

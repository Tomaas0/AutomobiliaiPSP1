using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class VairuotojasSuElektriniuAutomobiliu : Vairuotojas
    {
        public int Rida { get; set; }
        int MaxKmLikutis { get; set; }
        int KmLikutis { get; set; }
        public VairuotojasSuElektriniuAutomobiliu(int MaxKmLikutis = 700)
        {
            Rida = 0;
            this.MaxKmLikutis = MaxKmLikutis;
            this.KmLikutis = MaxKmLikutis;
        }

        override public void Vaziuoti(int km)
        {
            if (km < KmLikutis)
            {
                KmLikutis -= km;
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

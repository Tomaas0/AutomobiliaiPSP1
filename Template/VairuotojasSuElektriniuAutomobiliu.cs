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
        override protected void Vaziuoti(int km, double kuroDaugiklis)
        {
            int kiekReikiaDegalu = Int32.Parse((km * kuroDaugiklis).ToString("0"));
            if (kiekReikiaDegalu < KmLikutis)
            {
                KmLikutis -= kiekReikiaDegalu;
                Rida += km;
            }
        }
        override public double LikutisProc()
        {
            double proc = (double)KmLikutis / (double)MaxKmLikutis * 100;
            return proc;
        }
        override public int LikutisKm()
        {
            return KmLikutis;
        }
    }
}

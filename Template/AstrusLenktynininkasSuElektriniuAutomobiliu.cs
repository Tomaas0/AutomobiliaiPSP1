using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class AstrusLenktynininkasSuElektriniuAutomobiliu : Lenktynininkas
    {
        public int Rida { get; set; }
        int MaxKmLikutis { get; set; }
        int KmLikutis { get; set; }
        public AstrusLenktynininkasSuElektriniuAutomobiliu(int MaxKmLikutis = 700)
        {
            Rida = 0;
            this.MaxKmLikutis = MaxKmLikutis;
            this.KmLikutis = MaxKmLikutis;
        }

        override public void Lenktyniauti(int km)
        {
            int kiekReikiaDegalu = Int32.Parse((km * 1.5).ToString("0"));
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

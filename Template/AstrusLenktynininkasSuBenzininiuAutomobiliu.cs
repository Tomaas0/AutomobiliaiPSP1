using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class AstrusLenktynininkasSuBenzininiuAutomobiliu : Lenktynininkas
    {
        public int Rida { get; set; }
        int BakoTalpa { get; set; }
        double BakoLikutis { get; set; }
        double Sanaudos { get; set; }
        public AstrusLenktynininkasSuBenzininiuAutomobiliu(double Sanaudos, int BakoTalpa = 70)
        {
            Rida = 0;
            this.BakoTalpa = BakoTalpa;
            this.BakoLikutis = BakoTalpa;
            this.Sanaudos = Sanaudos;
        }

        override protected void Vaziuoti(int km, double kuroDaugiklis)
        {
            double kiekReikiaDegalu = Sanaudos * kuroDaugiklis / 100 * km;
            if (kiekReikiaDegalu < BakoLikutis)
            {
                BakoLikutis -= kiekReikiaDegalu;
                Rida += km;
            }
        }
        override public double LikutisProc()
        {
            return BakoLikutis / BakoTalpa * 100;
        }
        override public int LikutisKm()
        {
            double likutis = BakoLikutis / Sanaudos * 100;
            return Int32.Parse(likutis.ToString("0"));
        }
        override protected double Daugiklis(int km)
        {
            if (km > 100) return 1.3;
            else return 1.5;
        }
    }
}

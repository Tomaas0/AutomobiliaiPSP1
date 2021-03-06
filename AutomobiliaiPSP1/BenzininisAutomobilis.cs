﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliaiPSP1
{
    class BenzininisAutomobilis : IAutomobilis
    {
        public int Rida { get; set; }
        int BakoTalpa { get; set; }
        double BakoLikutis { get; set; }
        double Sanaudos { get; set; }
        public BenzininisAutomobilis (double Sanaudos, int BakoTalpa = 70)
        {
            Rida = 0;
            this.BakoTalpa = BakoTalpa;
            this.BakoLikutis = BakoTalpa;
            this.Sanaudos = Sanaudos;
        }

        public void Vaziuoti(int km, double daugiklis = 1)
        {
            double kiekReikiaDegalu = Sanaudos * daugiklis / 100 * km;
            if(kiekReikiaDegalu < BakoLikutis)
            {
                BakoLikutis -= kiekReikiaDegalu;
                Rida += km;
            }
        }
        public double LikutisProc()
        {
            return BakoLikutis / BakoTalpa * 100;
        }
        public int LikutisKm()
        {
            double likutis = BakoLikutis / Sanaudos * 100;
            return Int32.Parse(likutis.ToString("0"));
        }
    }
}

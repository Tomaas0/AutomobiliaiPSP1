using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliaiPSP1
{
    class PaprastasVaziavimas : IVaziavimoStilius
    {
        public double Daugiklis { get; }
        public PaprastasVaziavimas()
        {
            Daugiklis = 1.3;
        }
    }
}

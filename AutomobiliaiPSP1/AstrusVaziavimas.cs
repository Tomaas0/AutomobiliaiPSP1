using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliaiPSP1
{
    class AstrusVaziavimas : IVaziavimoStilius
    {
        public double Daugiklis { get; }
        public AstrusVaziavimas()
        {
            Daugiklis = 1.5;
        }
    }
}

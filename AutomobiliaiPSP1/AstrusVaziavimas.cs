using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliaiPSP1
{
    class AstrusVaziavimas : IVaziavimoStilius
    {
        public double Daugiklis(int km)
        {
            if (km > 100) return 1.3;
            else return 1.5;
        }
    }
}

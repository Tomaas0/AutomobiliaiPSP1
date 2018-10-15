using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliaiPSP1
{
    public interface IAutomobilis
    {
        int Rida { get; set; }
        void Vaziuoti(int km, double daugiklis = 1); 
        double LikutisProc();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliaiPSP1
{
    class Vairuotojas : IZmogus
    {
        public IAutomobilis TransportoPriemone { get; }
        public Vairuotojas(IAutomobilis car)
        {
            this.TransportoPriemone = car;
        }
        public void Vairuoti(int km)
        {
            TransportoPriemone.Vaziuoti(km);
            Console.WriteLine("Pravaziavo {0} km" , km);
            Console.WriteLine("Liko {0}% bako", TransportoPriemone.LikutisProc());
            Console.WriteLine("Dar galima nuvaziuoti {0}km", TransportoPriemone.LikutisKm());
            Console.WriteLine("");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliaiPSP1
{
    public class Lenktynininkas : IZmogus
    {
        public IVaziavimoStilius Stilius { get; }
        public IAutomobilis TransportoPriemone { get; }
        public Lenktynininkas(IAutomobilis car, IVaziavimoStilius stilius)
        {
            TransportoPriemone = car;
            Stilius = stilius;
        }
        public void Lenktyniauti(int km)
        {
            TransportoPriemone.Vaziuoti(km, Stilius.Daugiklis);
            Console.WriteLine("Pralenktyniavo {0} km", km);
            Console.WriteLine("Liko {0}% bako", TransportoPriemone.LikutisProc());
            Console.WriteLine("Dar galima nuvaziuoti {0}km", TransportoPriemone.LikutisKm());
            Console.WriteLine("");
        }
    }
}

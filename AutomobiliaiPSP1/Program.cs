using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliaiPSP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vairuotojas Tomas = new Vairuotojas(new BenzininisAutomobilis(10, 90));
            Vairuotojas Veganas = new Vairuotojas(new ElektrinisAutomobilis(400));

            Lenktynininkas Pirmas = new Lenktynininkas(new BenzininisAutomobilis(10, 90), new PaprastasVaziavimas());
            Lenktynininkas Antras = new Lenktynininkas(new BenzininisAutomobilis(10, 90), new AstrusVaziavimas());
            Lenktynininkas Trecias = new Lenktynininkas(new ElektrinisAutomobilis(400), new PaprastasVaziavimas());
            Lenktynininkas Ketvirtas = new Lenktynininkas(new ElektrinisAutomobilis(400), new AstrusVaziavimas());

            Tomas.Vairuoti(100);
            Veganas.Vairuoti(100);

            Pirmas.Lenktyniauti(50);
            Antras.Lenktyniauti(50);
            Trecias.Lenktyniauti(50);
            Ketvirtas.Lenktyniauti(50);
        }
    }
}

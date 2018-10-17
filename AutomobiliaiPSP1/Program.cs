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

            Tomas.Vaziuoti(100);
            Veganas.Vaziuoti(100);

            Pirmas.Lenktyniauti(50);
            Antras.Lenktyniauti(50);
            Trecias.Lenktyniauti(50);
            Ketvirtas.Lenktyniauti(50);

            Console.WriteLine(Tomas.TransportoPriemone.Rida);
            Console.WriteLine(Tomas.TransportoPriemone.LikutisProc());
            Console.WriteLine(Tomas.TransportoPriemone.LikutisKm());

            Console.WriteLine(Veganas.TransportoPriemone.Rida);
            Console.WriteLine(Veganas.TransportoPriemone.LikutisProc());
            Console.WriteLine(Veganas.TransportoPriemone.LikutisKm());

            Console.WriteLine(Pirmas.TransportoPriemone.Rida);
            Console.WriteLine(Pirmas.TransportoPriemone.LikutisProc());
            Console.WriteLine(Pirmas.TransportoPriemone.LikutisKm());

            Console.WriteLine(Antras.TransportoPriemone.Rida);
            Console.WriteLine(Antras.TransportoPriemone.LikutisProc());
            Console.WriteLine(Antras.TransportoPriemone.LikutisKm());

            Console.WriteLine(Trecias.TransportoPriemone.Rida);
            Console.WriteLine(Trecias.TransportoPriemone.LikutisProc());
            Console.WriteLine(Trecias.TransportoPriemone.LikutisKm());

            Console.WriteLine(Ketvirtas.TransportoPriemone.Rida);
            Console.WriteLine(Ketvirtas.TransportoPriemone.LikutisProc());
            Console.WriteLine(Ketvirtas.TransportoPriemone.LikutisKm());

        }
    }
}

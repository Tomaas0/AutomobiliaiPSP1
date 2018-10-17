using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            VairuotojasSuBenzininiuAutomobiliu Tomas = new VairuotojasSuBenzininiuAutomobiliu(10, 90);
            VairuotojasSuElektriniuAutomobiliu Veganas = new VairuotojasSuElektriniuAutomobiliu(400);

            LenktynininkasSuBenzininiuAutomobiliu Pirmas = new LenktynininkasSuBenzininiuAutomobiliu(10, 90);
            AstrusLenktynininkasSuBenzininiuAutomobiliu Antras = new AstrusLenktynininkasSuBenzininiuAutomobiliu(10, 90);
            LenktynininkasSuElektriniuAutomobiliu Trecias = new LenktynininkasSuElektriniuAutomobiliu(400);
            AstrusLenktynininkasSuElektriniuAutomobiliu Ketvirtas = new AstrusLenktynininkasSuElektriniuAutomobiliu(400);

            Tomas.Vaziuoti(100);
            Veganas.Vaziuoti(100);

            Pirmas.Lenktyniauti(50);
            Antras.Lenktyniauti(50);
            Trecias.Lenktyniauti(50);
            Ketvirtas.Lenktyniauti(50);

            Console.WriteLine(Tomas.Rida);
            Console.WriteLine(Tomas.LikutisProc());
            Console.WriteLine(Tomas.LikutisKm());

            Console.WriteLine(Veganas.Rida);
            Console.WriteLine(Veganas.LikutisProc());
            Console.WriteLine(Veganas.LikutisKm());

            Console.WriteLine(Pirmas.Rida);
            Console.WriteLine(Pirmas.LikutisProc());
            Console.WriteLine(Pirmas.LikutisKm());

            Console.WriteLine(Antras.Rida);
            Console.WriteLine(Antras.LikutisProc());
            Console.WriteLine(Antras.LikutisKm());

            Console.WriteLine(Trecias.Rida);
            Console.WriteLine(Trecias.LikutisProc());
            Console.WriteLine(Trecias.LikutisKm());

            Console.WriteLine(Ketvirtas.Rida);
            Console.WriteLine(Ketvirtas.LikutisProc());
            Console.WriteLine(Ketvirtas.LikutisKm());
        }
    }
}

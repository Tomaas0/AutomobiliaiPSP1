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

            Tomas.Vairuoti(100);
            Veganas.Vairuoti(100);

            Pirmas.Lenktyniauti(50);
            Antras.Lenktyniauti(50);
            Trecias.Lenktyniauti(50);
            Ketvirtas.Lenktyniauti(50);
        }
    }
}

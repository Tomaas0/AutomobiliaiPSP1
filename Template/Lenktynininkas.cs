using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    abstract class Lenktynininkas
    {
        double Daugiklis { get; }
        abstract public void Lenktyniauti(int km);
    }
}

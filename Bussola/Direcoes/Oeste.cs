using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussola.Direcoes
{
    public class Oeste : PontoCardeal, IPontoCardeal
    {
        public override EnumPontosCardeais VirarDireita()
        {
            return EnumPontosCardeais.Norte;
        }

        public override EnumPontosCardeais VirarEsquerda()
        {
            return EnumPontosCardeais.Sul;
        }

        public override string ToString()
        {
            return "O";
        }
    }
}

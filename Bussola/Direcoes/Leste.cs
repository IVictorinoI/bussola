using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussola.Direcoes
{
    public class Leste : PontoCardeal, IPontoCardeal
    {
        public override EnumPontosCardeais VirarDireita()
        {
            return EnumPontosCardeais.Sul;
        }

        public override EnumPontosCardeais VirarEsquerda()
        {
            return EnumPontosCardeais.Norte;
        }

        public override string ToString()
        {
            return "L";
        }
    }
}

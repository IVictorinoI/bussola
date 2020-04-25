using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussola.Direcoes
{
    public class Sul : PontoCardeal, IPontoCardeal
    {
        public override EnumPontosCardeais VirarDireita()
        {
            return EnumPontosCardeais.Oeste;
        }

        public override EnumPontosCardeais VirarEsquerda()
        {
            return EnumPontosCardeais.Leste;
        }

        public override string ToString()
        {
            return "S";
        }
    }
}

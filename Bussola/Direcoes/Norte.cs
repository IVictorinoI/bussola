using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussola.Direcoes
{
    public class Norte : PontoCardeal, IPontoCardeal
    {
        public override EnumPontosCardeais VirarDireita()
        {
            return EnumPontosCardeais.Leste;
        }

        public override EnumPontosCardeais VirarEsquerda()
        {
            return EnumPontosCardeais.Oeste;
        }

        public override string ToString()
        {
            return "N";
        }
    }
}

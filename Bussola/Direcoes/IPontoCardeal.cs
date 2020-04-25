using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussola.Direcoes
{
    public interface IPontoCardeal
    {
        EnumPontosCardeais VirarDireita();
        EnumPontosCardeais VirarEsquerda();
        EnumPontosCardeais Virar(EnumDirecoes direcao);
    }
}

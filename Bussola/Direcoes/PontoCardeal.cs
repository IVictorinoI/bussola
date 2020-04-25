using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussola.Direcoes
{
    public abstract class PontoCardeal : IPontoCardeal
    {
        public EnumPontosCardeais Virar(EnumDirecoes direcao)
        {
            switch (direcao)
            {
                case EnumDirecoes.Direita:
                    return this.VirarDireita();
                case EnumDirecoes.Esquerda:
                    return this.VirarEsquerda();
                default:
                    throw new NotImplementedException(string.Format("Direção {0} inválida.", direcao));
            }
        }

        public abstract EnumPontosCardeais VirarDireita();
        public abstract EnumPontosCardeais VirarEsquerda();
    }
}

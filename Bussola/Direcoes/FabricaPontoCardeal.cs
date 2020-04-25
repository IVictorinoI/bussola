using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussola.Direcoes
{
    public class FabricaPontoCardeal
    {
        public IPontoCardeal Criar(EnumPontosCardeais pontoAtual)
        {
            switch (pontoAtual)
            {
                case EnumPontosCardeais.Norte:
                    return new Norte();
                case EnumPontosCardeais.Sul:
                    return new Sul();
                case EnumPontosCardeais.Leste:
                    return new Leste();
                case EnumPontosCardeais.Oeste:
                    return new Oeste();
                default:
                    throw new NotImplementedException(string.Format("Ponto {0} não implementado.", pontoAtual.ToString()));
            }
        }
    }
}

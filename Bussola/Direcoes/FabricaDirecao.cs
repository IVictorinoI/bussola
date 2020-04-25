using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussola.Direcoes
{
    public class FabricaDirecao
    {
        public EnumDirecoes Criar(string direcao)
        {
            if (direcao.ToUpper() == "D")
            {
                return EnumDirecoes.Direita;
            }
            else if (direcao.ToUpper() == "E")
            {
                return EnumDirecoes.Esquerda;
            }
            else
            {
                throw new NotImplementedException(string.Format("Direção {0} inválida.", direcao));
            }
        }
    }
}

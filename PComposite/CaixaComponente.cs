using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PComposite
{
    public abstract class CaixaComponente //Contrato
    {
        public abstract float PegarPreco();

        public virtual void Adicionar(CaixaComponente leite) //Método Virtual não obrigatório o uso
        {
        }

        public virtual void Remover(CaixaComponente leite) 
        {
        }
    }
}

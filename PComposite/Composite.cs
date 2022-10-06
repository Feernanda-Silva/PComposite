using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PComposite
{

    public class Composite : CaixaComponente
    {
        // Filhos do composite, lista de produto
        List<CaixaComponente> leites = new List<CaixaComponente>();

        public override float PegarPreco() // override pois está sobrescrevendo o método abstrato a classe CaixaComponente herdada
        {
            float soma = 0;
            foreach (CaixaComponente leite in leites)
            {
                soma = soma + leite.PegarPreco();
            }

            return soma;
        }

        public override void Adicionar(CaixaComponente leite)
        {
            leites.Add(leite);
        }

        public override void Remover(CaixaComponente leite)
        {
            leites.Remove(leite);
        }

    }
}

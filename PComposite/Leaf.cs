using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PComposite
{

        public class Leaf : CaixaComponente
        {
            public int codigo;
            public string nome;
            public float preco;

            public Leaf (int codigo, string nome, float preco)
            {
                this.codigo = codigo;
                this.nome = nome;
                this.preco = preco;
            }

            public override float PegarPreco()
            {
                return this.preco;
            }
        }
    }


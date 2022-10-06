using System;

namespace PComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastrar produto");
            Leaf produto = new Leaf(1, "Leite Desnatado", 4);
            Leaf produto2 = new Leaf(2, "Leite Integral", 5);
            Leaf produto3 = new Leaf(3, "Leite Sem lactose", 6);

            float valorProduto = produto.PegarPreco();
            Console.WriteLine("Valor Leite Desnatado: " + valorProduto);

            float valorProduto2 = produto2.PegarPreco();
            Console.WriteLine("Valor Leite Integral: " + valorProduto2);

            float valorProduto3 = produto3.PegarPreco();
            Console.WriteLine("Valor Leite Sem Lactose: " + valorProduto3);


            // Caixa de Leite (Grande)
            Composite produtoCaixa = new Composite();
            produtoCaixa.Adicionar(produto);
            produtoCaixa.Adicionar(produto2);
            produtoCaixa.Adicionar(produto3);


            Console.WriteLine("\nSoma total das caixas: " + produtoCaixa.PegarPreco());


            //Remover um produto que foi adicionado na caixa
            Console.WriteLine("\nRemovendo produto: " + produto3.nome);
            produtoCaixa.Remover(produto3);

            Console.WriteLine("\nSoma total das caixas: " + produtoCaixa.PegarPreco());
        }
    }
}

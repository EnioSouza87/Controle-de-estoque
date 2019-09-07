using System;
using System.Globalization;

namespace exerc.Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(); // instancia da classe (OBJETO DA CLASSE PRODUTO)

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine(); // chamada do atributo da classe
            Console.Write("Preço: ");
            p.Preco = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture); // chamada do atributo da classe
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = Convert.ToInt32(Console.ReadLine()); // chamada do atributo da classe
            Console.Write("Digite o número de produtos a serem adicionados: ");
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p); // impressão do objeto usando o metodo override tostring
            Console.WriteLine();
            Console.WriteLine("DIGITE A QUANTIDADE A SER ADICIONADA NO ESTOQUE: ");
            int qtd = int.Parse(Console.ReadLine()); // criação e uso da variavel para armazenar a quantidade a ser adivionada
            p.AdicionarProdutos(qtd); // chamada do metodo feito para adicionar produtos da classe
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
            Console.WriteLine();
            Console.WriteLine("Digite a quantidade a ser removidada do estoque: ");
            int remove = int.Parse(Console.ReadLine()); // criação da variavel remove para quardar a quantidade que deseja remover do estoque
            p.RemoverProdutos(remove);  // chamada do metodo da classe que remove a quantidade em estoque 
            Console.WriteLine("Dados Atualizados: " + p); // impressão dos valores do objeto e classe usando o metodo OVERRIDE TOSTRING()


        }
    }
}

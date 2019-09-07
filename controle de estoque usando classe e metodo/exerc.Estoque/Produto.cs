using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exerc.Estoque
{
    class Produto
    {
        //declaração de atributos

        public string Nome;
        public double Preco;
        public int Quantidade;

        //DECLARAÇÃO DE METODOS
        public double ValorTotalEstoque() // metodo para calcular o valor total em estoque
        {
            return Preco * Quantidade; // calculo para dar o valor total dos produtos em estoque
                                        
        }


        public void AdicionarProdutos(int quantidade) // método para adicionar produtos
        {
            Quantidade = Quantidade + quantidade; // valor armazenado como quantidade recebe ela mesmo + o valor que foi digitado

        }

        public void RemoverProdutos(int quantidade) // metodo para remover produtos
        {
            Quantidade = Quantidade - quantidade; // valor armazenado como quantidade recebe ela mesmo - o valor a ser removido
        }
        public override string ToString() // Metodo ToString que retorna os valores dentro do objeto
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + " Unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }
        
        
    }
}

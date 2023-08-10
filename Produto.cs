using System;
using System.Globalization;

namespace ExercicioDeFixacao_EstoqueProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque () 
        { 
            return Quantidade * Preco; 
        }

        public void AdicionarProdutos (int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RetirarProduto (int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", $" 
                + Preco.ToString("f2", CultureInfo.InvariantCulture) 
                + ", " + Quantidade 
                + " unidades, Total: $"
                + ValorTotalEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}

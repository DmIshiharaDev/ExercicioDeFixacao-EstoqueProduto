using ExercicioDeFixacao_EstoqueProduto;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Produto p = new Produto();

        Console.WriteLine("Entre com os dados do produto:");
        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();
        Console.Write("Preço: ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade: ");
        p.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Dados do produto: \n" + p);

        Console.WriteLine();
        Console.Write("Digite a quantidade a ser adicionado ao estoque: ");
        int qte = int.Parse((string) Console.ReadLine());
        p.AdicionarProdutos(qte);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados do produto: \n" + p);

        Console.WriteLine();
        Console.Write("Digite a quantidade a ser removido ao estoque: ");
        int qte1 = int.Parse((string)Console.ReadLine());
        p.RetirarProduto(qte1);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados do produto: \n" + p);
    }
}
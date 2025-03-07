namespace Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1= new Produto(500, "Lapis", 2.50);
            Produto produto2 = new Produto(100, "Borracha", 5);
            Produto produto3 = new Produto(250, "Caneta", 10);

            Console.WriteLine(produto1.GetDetailProduct());
            Console.WriteLine(produto2.GetDetailProduct());
            Console.WriteLine(produto3.GetDetailProduct());
        }
    }
}

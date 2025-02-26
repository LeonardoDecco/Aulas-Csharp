internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, qual operação matematica deseja fazer ?");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplcação");
        Console.WriteLine("4 - Divisão \n");

        Console.ReadLine();

        int operacao = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro numero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());
    }
}

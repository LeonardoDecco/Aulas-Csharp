namespace calculadora_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, qual operação deseja calcular: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão \n");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado;

            if (operacao == 1)
            {
                resultado = num1 + num2;
                Console.WriteLine($"O resultado da adição é: {resultado}");
            }
            else if (operacao == 2)
            {
                resultado = num1 - num2;
                Console.WriteLine($"O resultado da subtração é: {resultado}");
            }
            else if (operacao == 3)
            {
                resultado = num1 * num2;
                Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            }
            else if (operacao == 4)
            {
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"O resultado da divisão é: {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero.");
                }
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        int num, i = 0, j = 1, box, resp;

        do
        {
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            // Calcula a sequência de Fibonacci até o número informado pelo usuário
            while (j < num)
            {
                box = i + j;
                i = j;
                j = box;
            }

            // Verifica se o número informado pertence à sequência de Fibonacci
            if (j == num)
            {
                Console.WriteLine("O número informado pertence à sequência de Fibonacci.\n");
            }
            else
            {
                Console.WriteLine("O número informado não pertence à sequência de Fibonacci.\n");
            }

            Console.Write("Gostaria de consultar outro número? (1)Sim (2)Não: \n");
            resp = int.Parse(Console.ReadLine());

        } while (resp == 1);
    }
}

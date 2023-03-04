using System;

class Program
{
    static void Main(string[] args)
    {
        string palavra, inverso;
        int resp;

        do
        {
            inverso = ""; //Limpando a variável
            Console.Write("Digite uma palavra: ");
            palavra = Console.ReadLine();

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                inverso += palavra[i];//Adicionando cada letra da palavra invertida na variável "inverso"
            }

            Console.WriteLine("Inversão: " + inverso);

            Console.Write("Gostaria de inverter outra palavra? (1)Sim ou (2)Não: ");
            resp = int.Parse(Console.ReadLine());

        } while (resp == 1);
    }
}

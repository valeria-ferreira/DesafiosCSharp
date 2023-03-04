using System;

class Program
{
    static void Main(string[] args)
    {
        //Vetores 
        int[] dias = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        double[] valores = { 22174.1664, 24537.6698, 26139.6134, 0.0, 0.0, 26742.6612, 0.0, 42889.2258, 46251.174, 11191.4722, 0.0, 0.0, 3847.4823, 373.7838, 2659.7563, 48924.2448, 18419.2614, 0.0, 0.0, 35240.1826, 43829.1667, 18235.6852, 4355.0662, 13327.1025, 0.0, 0.0, 25681.8318, 1718.1221, 13220.495, 8414.61 };
        double media, soma, menor, maior;
        int diasAcimaMedia = 0, contador, i;

        //Calculaando o menor e o maior valor de faturamento ocorrido em um dia do mês
        menor = valores[0];
        maior = valores[0];

        for (i = 1; i < valores.Length; i++)
        {
            if (valores[i] < menor)
            {
                menor = valores[i];
            }
            if (valores[i] > maior)
            {
                maior = valores[i];
            }
        }
        Console.WriteLine("Menor faturamento diário: {0}", menor);
        Console.WriteLine("Maior faturamento diário: {0}", maior);

        //Calculaando a média mensal de faturamento, ignorando os dias sem faturamento
        soma = 0.0;
        contador = 0;

        for (i = 0; i < valores.Length; i++)
        {
            if (valores[i] > 0.0)
            {
                soma += valores[i];
                contador++;
            }
        }
        media = soma / contador;

        //Contaando o número de dias no mês em que o valor de faturamento diário foi superior à média mensal
        for (i = 0; i < valores.Length; i++)
        {
            if (valores[i] > media)
            {
                diasAcimaMedia++;
            }
        }
        Console.WriteLine("Número de dias com faturamento diário acima da média: {0}", diasAcimaMedia);
    }
}

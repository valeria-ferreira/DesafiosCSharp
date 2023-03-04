using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração dos vetores de faturamento e estado, e das outras variáveis 
        double[] faturamento = new double[5];
        string[] estado = new string[5];
        double total = 0, percentual;
        int i;

        // Atribuição dos vetores
        faturamento[0] = 67.83643;
        faturamento[1] = 36.67866;
        faturamento[2] = 29.22988;
        faturamento[3] = 27.16548;
        faturamento[4] = 19.84953;

        estado[0] = "SP";
        estado[1] = "RJ";
        estado[2] = "MG";
        estado[3] = "ES";
        estado[4] = "OUTROS";

        // Loop para calcular o total do faturamento
        for (i = 0; i < 5; i++)
        {
            total += faturamento[i];
        }

        // Mostrando o total
        Console.WriteLine("Total de faturamento: R${0:F2}", total);

        // Loop para calcular o percentual de cada estado e mostrar o resultado
        for (i = 0; i < 5; i++)
        {
            percentual = (faturamento[i] / total) * 100;
            Console.WriteLine("Percentual de {0}: {1:F2}%", estado[i], percentual);
        }
    }
}

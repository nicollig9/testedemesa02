using System;

class Tabela5
{
    static void Main()
    {
        double valorFuturo = 7390.61;
        double taxaJuros = 1.25 / 100;
        int periodoAnos = 2;

        double valorPresente;

        valorPresente = valorFuturo / Math.Pow(1 + taxaJuros, periodoAnos);

        Console.WriteLine("Valor Futuro: R$ " + valorFuturo);
        Console.WriteLine("Taxa de Juros: " + (taxaJuros * 100) + "%");
        Console.WriteLine("Periodo: " + periodoAnos + " anos");
        Console.WriteLine("Valor Presente: R$ " + valorPresente.ToString("F2"));
    }
}
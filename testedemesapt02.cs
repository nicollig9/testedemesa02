

using System;

class Tabela1
{
    static void Main()
    {
        double valorPresente = 1000.00;
        double taxaJuros = 5.30 / 100;
        int periodoMeses = 6;

        double valorFuturo;

        valorFuturo = valorPresente * Math.Pow(1 + taxaJuros, periodoMeses);

        Console.WriteLine("Valor Presente: R$ " + valorPresente);
        Console.WriteLine("Taxa de Juros: " + (taxaJuros * 100) + "%");
        Console.WriteLine("Período: " + periodoMeses + " meses");
        Console.WriteLine("Valor Futuro: R$ " + valorFuturo.ToString("F2"));
    }
}


using System;

class Tabela2
{
    static void Main()
    {
        double valorPresente = 3800.00;
        double taxaJuros = 1.25 / 100;

        int mes = 1;

        double rendimento;
        double rendimentoLiquido;
        double rendaAcumulada = valorPresente;

        Console.WriteLine("MES\tRENDIMENTO\tLUCRO\t\tACUMULADO");

        while (mes <= 6)
        {
            rendimento = valorPresente * Math.Pow(1 + taxaJuros, mes);

            rendimentoLiquido = rendimento - valorPresente;

            rendaAcumulada = rendimento;

            Console.WriteLine(
                mes + "\tR$ " +
                rendimento.ToString("F2") +
                "\tR$ " +
                rendimentoLiquido.ToString("F2") +
                "\tR$ " +
                rendaAcumulada.ToString("F2")
            );

            mes++;
        }
    }
}


using System;

namespace Tabela3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite o Valor Presente: ");
            double valorPresente = double.Parse(Console.ReadLine());

            Console.Write("Digite a Taxa de Juros (ex: 2 para 2%): ");
            double taxaJuros = double.Parse(Console.ReadLine()) / 100; 

            Console.Write("Digite o Período (anos): ");
            int periodoAnos = int.Parse(Console.ReadLine());

           
            double valorFuturo = valorPresente * Math.Pow((1 + taxaJuros), periodoAnos);

           
            
            Console.WriteLine("Valor Inicial: R$ " + valorPresente);
            Console.WriteLine("Valor Total Acumulado: R$ " + valorFuturo.ToString("N2"));
            Console.WriteLine("Rendimento (Lucro): R$ " + (valorFuturo - valorPresente).ToString("N2"));
        }
    }
}
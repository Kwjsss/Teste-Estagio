using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<EstadoFaturamento> faturamentos = new List<EstadoFaturamento>()
        {
            new EstadoFaturamento("SP", 67836.43),
            new EstadoFaturamento("RJ", 36678.66),
            new EstadoFaturamento("MG", 29229.88),
            new EstadoFaturamento("ES", 27165.48),
            new EstadoFaturamento("Outros", 19849.53)
        };

            FaturamentoService service = new FaturamentoService(faturamentos);

            double faturamentoTotal = service.CalcularFaturamentoTotal();

            Dictionary<string, double> percentuais = service.CalcularPercentuais(faturamentoTotal);

            foreach (var percentual in percentuais)
            {
                Console.WriteLine($"Estado: {percentual.Key} - Percentual: {percentual.Value:F2}%");
            }
            Console.ReadKey();
        }
    }
}

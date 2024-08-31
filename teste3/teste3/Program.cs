using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = "faturamento.json";

            FaturamentoService service = new FaturamentoService(caminhoArquivo);

            double menorFaturamento = service.CalcularMenorFaturamento();
            double maiorFaturamento = service.CalcularMaiorFaturamento();

            double mediaMensal = service.CalcularMediaMensal();

            int diasAcimaMedia = service.ContarDiasAcimaDaMedia(mediaMensal);

            Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");
            Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");
            Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaMedia}");
            Console.ReadKey();
        }
    }
}

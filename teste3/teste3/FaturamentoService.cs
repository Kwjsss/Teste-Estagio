using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace teste3
{
    internal class FaturamentoService
    {
        private List<Faturamento> faturamentos;

        public FaturamentoService(string caminhoArquivo)
        {
            this.faturamentos = LerFaturamento(caminhoArquivo);
        }

        public double CalcularMenorFaturamento()
        {
            double menor = double.MaxValue;
            foreach (var item in faturamentos)
            {
                if (item.FaturamentoDiario < menor)
                {
                    menor = item.FaturamentoDiario;
                }
            }
            return menor;
        }

        public double CalcularMaiorFaturamento()
        {
            double maior = double.MinValue;
            foreach (var item in faturamentos)
            {
                if (item.FaturamentoDiario > maior)
                {
                    maior = item.FaturamentoDiario;
                }
            }
            return maior;
        }

        public double CalcularMediaMensal()
        {
            double totalFaturamento = 0;
            int diasComFaturamento = 0;

            foreach (var item in faturamentos)
            {
                if (item.FaturamentoDiario > 0) 
                {
                    totalFaturamento += item.FaturamentoDiario;
                    diasComFaturamento++;
                }
            }

            if (diasComFaturamento == 0)
            {
                return 0;
            }

            return totalFaturamento / diasComFaturamento;
        }

        public int ContarDiasAcimaDaMedia(double mediaMensal)
        {
            int count = 0;

            foreach (var item in faturamentos)
            {
                if (item.FaturamentoDiario > mediaMensal)
                {
                    count++;
                }
            }

            return count;
        }

        private List<Faturamento> LerFaturamento(string caminhoArquivo)
        {
            string json = File.ReadAllText(caminhoArquivo);
            return JsonConvert.DeserializeObject<List<Faturamento>>(json);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste4
{
    internal class FaturamentoService
    {
        private List<EstadoFaturamento> faturamentos;

        public FaturamentoService(List<EstadoFaturamento> faturamentos)
        {
            this.faturamentos = faturamentos;
        }

        public double CalcularFaturamentoTotal()
        {
            double total = 0;
            foreach (var estado in faturamentos)
            {
                total += estado.Faturamento;
            }
            return total;
        }

        public Dictionary<string, double> CalcularPercentuais(double faturamentoTotal)
        {
            Dictionary<string, double> percentuais = new Dictionary<string, double>();

            foreach (var estado in faturamentos)
            {
                double percentual = (estado.Faturamento / faturamentoTotal) * 100;
                percentuais[estado.Estado] = percentual;
            }

            return percentuais;
        }
    }
}

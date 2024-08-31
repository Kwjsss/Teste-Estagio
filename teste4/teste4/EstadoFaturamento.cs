using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste4
{
    internal class EstadoFaturamento
    {
        public string Estado { get; set; }
        public double Faturamento { get; set; }

        public EstadoFaturamento(string estado, double faturamento)
        {
            Estado = estado;
            Faturamento = faturamento;
        }
    }
}

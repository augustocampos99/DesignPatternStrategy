using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy.Entities
{
    public class Orcamento
    {
        public Orcamento()
        {
            this.DataCalculo = DateTime.Now;
        }

        public DateTime DataCalculo { get; set; }

        public double Valor { get; set; }

        public double ValorImposto { get; set; }
    }
}

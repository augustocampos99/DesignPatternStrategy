using DesignPatternStrategy.Entities;
using DesignPatternStrategy.Services;
using System;

namespace DesignPatternStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var calcularImpostoService = new CalcularImpostoService();
            var impostoIcmsService = new ImpostoIcmsService();
            var impostoIssService = new ImpostoIssService();

            var orcamento = new Orcamento { Valor = 150 };

            var orcamentoComIcms = calcularImpostoService.CalcularOrcamento(orcamento, impostoIcmsService);
            var orcamentoComIss = calcularImpostoService.CalcularOrcamento(orcamento, impostoIssService);

            Console.WriteLine("ICMS => " + orcamentoComIcms);
            Console.WriteLine("ISS  => " + orcamentoComIss);
        }
    }
}

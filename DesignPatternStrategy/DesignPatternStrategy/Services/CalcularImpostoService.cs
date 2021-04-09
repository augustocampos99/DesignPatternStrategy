using DesignPatternStrategy.Entities;
using DesignPatternStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy.Services
{
    public class CalcularImpostoService
    {
        public double CalcularOrcamento(Orcamento orcamento, IImpostoService imposto)
        {
            try
            {
                double valorImposto = imposto.CalcularImposto(orcamento.Valor);
                orcamento.ValorImposto += valorImposto;
                return valorImposto;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no calculo do orçamento: " + ex.Message);
            }
        }
    }
}

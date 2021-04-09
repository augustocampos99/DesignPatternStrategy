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
                return imposto.CalcularImposto(orcamento.Valor);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no calculo do orçamento: " + ex.Message);
            }
        }
    }
}

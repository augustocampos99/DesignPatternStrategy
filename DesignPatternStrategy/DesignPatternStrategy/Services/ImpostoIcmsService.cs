using DesignPatternStrategy.Entities;
using DesignPatternStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy.Services
{
    public class ImpostoIcmsService : IImpostoService
    {
        public double CalcularImposto(double valor)
        {
            double icms = 0.18;
            return valor * icms; 
        }
    }
}

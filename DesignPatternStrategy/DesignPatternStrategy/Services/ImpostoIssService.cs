using DesignPatternStrategy.Entities;
using DesignPatternStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy.Services
{
    public class ImpostoIssService : IImpostoService
    {
        public double CalcularImposto(double valor)
        {
            double iss = 0.05;
            return valor * iss; 
        }
    }
}

using DesignPatternStrategy.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy.Interfaces
{
    public interface IImpostoService
    {
        double CalcularImposto(double valor);
    }
}

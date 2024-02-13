using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Strategy
{
    public interface IFormas
    {
        decimal CalcularArea();
        decimal CalcularPerimetro();
        string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string idioma);
    }
}

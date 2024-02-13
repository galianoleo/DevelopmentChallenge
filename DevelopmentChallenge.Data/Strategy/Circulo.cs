using DevelopmentChallenge.Data.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Strategy
{
    public class Circulo : IFormas
    {
        public Circulo()
        {

        }
        private decimal _lado;
        public Circulo(decimal lado)
        {
            _lado = lado;
        }
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro,string idioma)
        {
            var message = new MessagesProvider();
            if (cantidad > 0)
            {
                var linea = message.GetTranslation("Line", idioma);
                return String.Format(linea, cantidad, TraducirForma(cantidad, idioma), area, perimetro);
            }

            return string.Empty;
        }

        private string TraducirForma(int cantidad, string idioma)
        {
            var message = new MessagesProvider();
            return message.GetTranslation(cantidad > 1 ? "Circles" : "Circle", idioma);

        }
    }
}

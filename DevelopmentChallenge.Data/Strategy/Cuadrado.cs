using DevelopmentChallenge.Data.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Strategy
{
    public class Cuadrado:IFormas
    {
        public Cuadrado()
        {

        }
        private decimal _lado;
        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string idioma)
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
            return message.GetTranslation(cantidad > 1 ? "Squares" : "Square", idioma);

        }
    }
}

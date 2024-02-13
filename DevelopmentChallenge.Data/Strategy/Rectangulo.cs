using DevelopmentChallenge.Data.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Strategy
{
    public class Rectangulo : IFormas
    {
        public Rectangulo()
        {

        }
        private decimal _ladoBase;
        private decimal _altura;
        public Rectangulo(decimal ladoBase, decimal altura)
        {
            _ladoBase = ladoBase;
            _altura = altura;
        }
        public decimal CalcularArea()
        {
            return _ladoBase * _altura;
        }

        public decimal CalcularPerimetro()
        {
            return (2 * _ladoBase) + (2 * _altura);
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
            return message.GetTranslation(cantidad > 1 ? "Rectangles" : "Rectangle", idioma);

        }
    }
}

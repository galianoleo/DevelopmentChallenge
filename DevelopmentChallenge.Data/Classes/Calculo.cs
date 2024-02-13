using DevelopmentChallenge.Data.Provider;
using DevelopmentChallenge.Data.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Calculo
    {
        private static MessagesProvider message = new MessagesProvider();
        public static string Imprimir(List<IFormas> formas, string idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(message.GetTranslation("EmptyList", idioma));
            }
            else
            {
                sb.Append(message.GetTranslation("ShapesReport", idioma));
                var reflection = new ReflectionFactory();


                var totalArea = 0m;
                var totalPerimetro = 0m;
                var totalFormas = 0m;
                var group = formas.GroupBy(x => x.GetType());
                foreach (var item in group)
                {
                    //var objeto = reflection.CrearForma(item.Key);
                    var cantidad = item.Count();
                    totalFormas += cantidad;
                    var areaByForm = 0m;
                    var perimetroByform = 0m;
                    var obj = reflection.CrearForma(item.Key.ToString());
                    foreach (var f in item)
                    {
                        areaByForm += f.CalcularArea();
                        totalArea += f.CalcularArea();
                        perimetroByform += f.CalcularPerimetro();
                        totalPerimetro += f.CalcularPerimetro();
                    }
                    sb.Append(obj.ObtenerLinea(cantidad, areaByForm, perimetroByform, idioma));
                }

                // FOOTER
                sb.Append(message.GetTranslation("Total", idioma));
                sb.Append(totalFormas + " " + message.GetTranslation("Shapes", idioma) + " ");
                sb.Append(message.GetTranslation("Perimeter", idioma) + (totalPerimetro).ToString("#.##") + " ");
                sb.Append(message.GetTranslation("Area", idioma) + (totalArea).ToString("#.##"));
            }
            return sb.ToString();

        }
    }
}

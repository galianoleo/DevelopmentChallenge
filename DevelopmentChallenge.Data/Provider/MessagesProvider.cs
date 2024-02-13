using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Provider
{
    public class MessagesProvider
    {
        private IList<MessagesDto> _messagesList = new List<MessagesDto>();
        public MessagesProvider()
        {
            //es
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "EmptyList", Translation = "<h1>Lista vacía de formas!</h1>" });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "ShapesReport", Translation = "<h1>Reporte de Formas</h1>" });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "Total", Translation = "TOTAL:<br/>" });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "Shapes", Translation = "formas" });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "Perimeter", Translation = "Perimetro " });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "Area", Translation = "Area " });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "Square", Translation = "Cuadrado" });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "Squares", Translation = "Cuadrados" });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "Circle", Translation = "Círculo" });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "Circles", Translation = "Círculos" });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "Triangle", Translation = "Triángulo" });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "Triangles", Translation = "Triángulos" });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "Rectangle", Translation = "Rectángulo" });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "Rectangles", Translation = "Rectángulos" });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "UnknownShape", Translation = "Forma desconocida" });
            _messagesList.Add(new MessagesDto() { Culture = "es", Key = "Line", Translation = "{0} {1} | Area {2:#.##} | Perimetro {3:#.##} <br/>" });
            //en
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "EmptyList", Translation = "<h1>Empty list of shapes!</h1>" });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "ShapesReport", Translation = "<h1>Shapes report</h1>" });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "Total", Translation = "TOTAL:<br/>" });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "Shapes", Translation = "shapes" });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "Perimeter", Translation = "Perimeter " });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "Area", Translation = "Area " });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "Square", Translation = "Square" });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "Squares", Translation = "Squares" });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "Circle", Translation = "Circle" });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "Circles", Translation = "Circles" });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "Triangle", Translation = "Triangle" });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "Triangles", Translation = "Triangles" });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "Rectangle", Translation = "Rectangle" });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "Rectangles", Translation = "Rectangles" });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "UnknownShape", Translation = "Unknown Shape" });
            _messagesList.Add(new MessagesDto() { Culture = "en", Key = "Line", Translation = "{0} {1} | Area {2:#.##} | Perimeter {3:#.##} <br/>" });

            //it
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "EmptyList", Translation = "<h1>Elenco vuoto di forme!</h1>" });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "ShapesReport", Translation = "<h1>Rapporto sui moduli</h1>" });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "Total", Translation = "TOTALE:<br/>" });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "Shapes", Translation = "forme" });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "Perimeter", Translation = "Perimetro " });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "Area", Translation = "La zona " });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "Square", Translation = "Piazza" });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "Squares", Translation = "Piazze" });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "Circle", Translation = "Cerchio" });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "Circles", Translation = "Cerchi" });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "Triangle", Translation = "Triangolo" });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "Triangles", Translation = "triangoli" });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "Rectangle", Translation = "Rettangolo" });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "Rectangles", Translation = "Rettangoli" });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "UnknownShape", Translation = "forma sconosciuta" });
            _messagesList.Add(new MessagesDto() { Culture = "it", Key = "Line", Translation = "{0} {1} | Zona {2:#.##} | Perimetro {3:#.##} <br/>" });
        }
        public string GetTranslation(string key, string culture)
        {
            Func<string, string> func = (string value) => value.ToLower();
            var message = _messagesList.FirstOrDefault(x => x.Culture.Equals(culture) && x.Key.Equals(key));
            if (message == null)
                throw new Exception("ErrTranslationNotFound");

            return message.Translation;
        }
    }
}

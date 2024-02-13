using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Strategy
{
    public class ReflectionFactory
    {
        public IFormas CrearForma(string typeName)
        {
            Type type = Type.GetType(typeName);

            if (type == null)
            {
                throw new ArgumentException("Tipo no válido", nameof(typeName));
            }

            object instance = Activator.CreateInstance(type);

            if (instance is IFormas product)
            {
                return product;
            }
            else
            {
                throw new InvalidOperationException($"El tipo {typeName} no implementa la interfaz ICalculos.");
            }
        }
    }
}

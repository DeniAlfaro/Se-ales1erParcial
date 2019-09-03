using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class Sinc
    {
        public List<Muestra> Muestras { get; set; }

        public Sinc()
        {
            Muestras = new List<Muestra>();
        }
        public double evaluar(double tiempo)
        {
            double resultado;
            resultado = (Math.Sin(Math.PI * tiempo)) / (Math.PI * tiempo);

            return resultado;
        }
    }
}

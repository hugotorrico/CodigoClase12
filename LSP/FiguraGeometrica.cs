using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class FiguraGeometrica
    {
        public virtual double CalcularArea()
        {
            return 0;
        }
    }

    public class Rectangulo : FiguraGeometrica
    {
        public double Ancho { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return Ancho * Altura;
        }
    }

    public class Cuadrado : FiguraGeometrica
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }

}

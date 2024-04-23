using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{   
    public class CalculadoraAreas
    {
        public double CalcularArea(string forma, double medida, double medida2)
        {
            if (forma=="Rectangulo")
            {
                return medida * medida2;
            }
         
            if (forma == "Cuadrado")
            {
                return medida * medida;
            }
            else if (forma == "Circulo")
            {
                return Math.PI * medida * medida;
            }
            else
            {
                throw new ArgumentException("Forma no válida");
            }
        }
    }

    public abstract class Figura
    {
        public int Medida { get; set; }
        public abstract double CalcularArea();
    }
    public class Circulo : Figura
    {
        public override double CalcularArea()
        {
            return Medida * Medida;
        }
    }

    public class Cuadrado : Figura
    {
        public override double CalcularArea()
        {
            return Math.PI * Medida * Medida;
        }
    }

    public class Rectangulo : Figura
    {
        public int Medida2 { get; set; }
        public override double CalcularArea()
        {
            return  Medida * Medida2;
        }
    }

}

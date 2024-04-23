using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; } // No es una buena práctica usar una cadena para identificar el tipo

        public double CalcularSueldo()
        {
            double sueldo = 0;

            if (Tipo == "Base")
            {
                // Cálculo del sueldo para empleado base
                sueldo = CalcularSueldoBase();
            }
            else if (Tipo == "Comision")
            {
                // Cálculo del sueldo para empleado por comisión
                sueldo = CalcularSueldoComision();
            }

            return sueldo;
        }

        private double CalcularSueldoBase()
        {
            // Lógica de cálculo para empleado base
            return 2000;
        }

        private double CalcularSueldoComision()
        {
            // Lógica de cálculo para empleado por comisión
            return 1000;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Calculadora
    {
        public int RealizarOperacion(int a, int b, string operacion)
        {
            if (operacion == "Suma")
            {
                return a + b;
            }
            else if (operacion == "Resta")
            {
                return a - b;
            }
            else
            {
                throw new ArgumentException("Operación no válida");
            }
        }
    }

}

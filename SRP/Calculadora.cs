using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            // Lógica para sumar dos números
            return a + b;
        }
        public int Restar(int a, int b)
        {
            // Lógica para restar dos números
            return a - b;
        }
       
    }
    public class CalculadoraPresentacion
    {
        public void MostrarResultado(int resultado)
        {
            // Lógica para mostrar el resultado de una operación
        }
    }

    public class Sumador
    {
        public int Sumar(int a, int b)
        {
            // Lógica para sumar dos números
            return a + b;
        }

    }

    public class Restador
    {
        public int Restar(int a, int b)
        {
            // Lógica para restar dos números
            return a - b;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase12
{
    using System;

    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }
        public int Antiguedad { get; set; }
        public decimal VentasMes { get; set; }
        public int nHijos { get; set; }
        public abstract decimal CalcularSalarioTotal();
    }

    public class EmpleadoBonificacionVentas : Empleado
    {
        public override decimal CalcularSalarioTotal()
        {
            return VentasMes * 0.05m;
        }
    }

    public class EmpleadoBonificacionAntiguedad : Empleado
    {
        public override decimal CalcularSalarioTotal()
        {
            return Antiguedad * 1000;
        }
    }


    public class EmpleadoBonificacioNHijos : Empleado
    {
        public override decimal CalcularSalarioTotal()
        {
            return nHijos * 100; 
        }
    }

  
    class Program
    {
        static void Main()
        {
            
            Empleado empleado1 = new EmpleadoBonificacionVentas { Nombre = "Juan", SalarioBase = 2000, Antiguedad = 3 };
            Empleado empleado2 = new EmpleadoBonificacionAntiguedad { Nombre = "María", SalarioBase = 1500, VentasMes = 5000 };
            Empleado empleado3 = new EmpleadoBonificacioNHijos { Nombre = "Pedro", SalarioBase = 1800, nHijos = 5 };

            Console.WriteLine($"Salario total de {empleado1.Nombre}: {empleado1.CalcularSalarioTotal()}");
            Console.WriteLine($"Salario total de {empleado2.Nombre}: {empleado2.CalcularSalarioTotal()}");
            Console.WriteLine($"Salario total de {empleado3.Nombre}: {empleado3.CalcularSalarioTotal()}");
            
        }
    }

}

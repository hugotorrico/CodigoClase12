using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Modelos
{
    //Modelos/Entidades/Dominio

    public class Empleado
    {
        public string Nombre { get; set; }

        //Salario >0
        public decimal Salario { get; set; }


        //Edad>0
        public int Edad { get; set; }

        //Logintud=8
        //Digitos sean números
        public string DNI { get; set; }


    }

}

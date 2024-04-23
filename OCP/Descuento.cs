using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Descuento
    {
        public decimal AplicarDescuento(decimal precio, string tipoCliente)
        {
            if (tipoCliente == "Regular")
            {
                return precio * 0.9m; // Descuento del 10% para clientes regulares
            }
            else if (tipoCliente == "VIP")
            {
                return precio * 0.8m; // Descuento del 20% para clientes VIP
            }
            else
            {
                return precio;
            }
        }
    }
}

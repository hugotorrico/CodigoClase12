using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Descuento2
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
                return precio*0.5m;
            }
        }
    }

    public  class Descuento
    {
        
        public decimal Precio { get; set; }
        public virtual decimal Aplicar()
        {
            return Precio*0.5m;
        }

    }
    public class DescuentoRegular : Descuento
    {
        public override decimal Aplicar()
        {
            return Precio * 0.9m;
        }
    }
    public class DescuentoVIP : Descuento
    {
        public override decimal Aplicar()
        {
            return Precio * 0.8m;
        }
    }


}

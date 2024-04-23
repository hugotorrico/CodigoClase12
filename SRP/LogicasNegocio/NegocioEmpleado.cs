using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.LogicasNegocio
{
    public class NegocioEmpleado
    {
        public void CalcularBonificacion()
        {
            // Lógica para calcular la bonificación del empleado
        }

        public void LeerContrato()
        {
            FileRead fileRead1 = new FileRead();
            fileRead1.LeerArchivoPDF("RutaContrato.PDF");
        }
    }
}

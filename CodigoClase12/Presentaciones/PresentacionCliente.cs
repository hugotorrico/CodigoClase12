using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoClase12.Modelos;

namespace CodigoClase12.Presentaciones
{
    public class PresentacionCliente
    {
        #region Presentacion
        // Método que viola el SRP al tener una responsabilidad adicional de mostrar información
        public void MostrarInformacion(Cliente cliente)
        {
            // Lógica para mostrar la información del cliente
            Console.WriteLine($"ID: {cliente.Id}, Nombre: {cliente.Nombre}, Dirección: {cliente.Direccion}");
        }
        #endregion
    }
}

//Ruben Bernal Ramos, CSI1

using Ejercicio2_Listas_Prog.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Listas_Prog.servicios
{
    /// <summary>
    /// Interfaz para la solicitud de los datos del cliente para el registro
    /// rbr - 141123
    /// </summary>
    internal interface RegistrarInterfaz
    {
        /// <summary>
        /// Enunciado del método que tendrá la implementación
        /// rbr - 141123
        /// </summary>
        /// <returns></returns>
        public void solicitudDatos(List<ClienteDto> listaAntigua);
    }
}

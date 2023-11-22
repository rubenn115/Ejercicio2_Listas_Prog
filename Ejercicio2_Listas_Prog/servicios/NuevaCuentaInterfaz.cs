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
    /// Interfaz para la creación de una nueva cuenta bancaria
    /// rbr - 221123
    /// </summary>
    internal interface NuevaCuentaInterfaz
    {
        /// <summary>
        /// Enunciado del método que tendrá la implementación
        /// rbr - 221123
        /// </summary>
        /// <param name="listaCuentasAntigua"></param>
        public void solicitarDatos(List<CuentaDto> listaCuentasAntigua);
    }
}

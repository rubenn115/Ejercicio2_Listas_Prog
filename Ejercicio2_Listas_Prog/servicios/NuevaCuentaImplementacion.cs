//Ruben Bernal Ramos, CSI1

using Ejercicio2_Listas_Prog.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Listas_Prog.servicios
{
    /// <summary>
    /// Implementación de la interfaz NuevaCuenta
    /// rbr - 221123
    /// </summary>
    internal class NuevaCuentaImplementacion : NuevaCuentaInterfaz
    {
        /// <summary>
        /// Método que solicitará por consola los datos para crear una cuenta bancaria nueva
        /// rbr - 221123
        /// </summary>
        /// <param name="listaCuentasAntigua"></param>
        public void solicitarDatos(List<CuentaDto> listaCuentasAntigua)
        {
            //Creo el objeto cliente
            CuentaDto cuenta = new CuentaDto();

            //Solicito los datos del cliente por consola
            cuenta.Id = listaCuentasAntigua.Count+1;
            Console.WriteLine("Introduce el isban (Introduce 'ES-23-' más 20 digitos ): ");
            cuenta.Isban = Console.ReadLine();
            cuenta.CodigoSwitch = "CSI1SSXX";
            cuenta.FechaAlta = Convert.ToString(DateTime.Now);
            /*Declaro la varible como null porque al darse de alta como nuevo
            cliente no puede haber ninguna fecha de baja*/
            cuenta.FechaBaja = Convert.ToString(null);
            Console.WriteLine("Introduce el identificador (Dni del cliente): ");
            cuenta.IdentificadorCliente = Console.ReadLine();
            //Guardo el cliente en la lista
            listaCuentasAntigua.Add(cuenta);

            Console.WriteLine(cuenta.ToString());
        }
    }
}

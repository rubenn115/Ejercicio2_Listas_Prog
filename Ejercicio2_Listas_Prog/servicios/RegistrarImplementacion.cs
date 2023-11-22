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
    /// Implementación de la interfaz Solicitar
    /// rbr - 141123
    /// </summary>
    internal class RegistrarImplementacion : RegistrarInterfaz
    {
        /// <summary>
        /// Método que solicitará por consola los datos para el registro de un nuevo cliente
        /// rbr - 141123
        /// </summary>
        /// <returns></returns>
        public void solicitudDatos(List<ClienteDto> listaAntigua)
        {
            //Creo el objeto cliente
            ClienteDto cliente = new ClienteDto();

            //Solicito los datos del cliente por consola
            Console.WriteLine("Introduce el nombre: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduce los apellidos: ");
            cliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduce el dni: ");
            cliente.DniCliente = Console.ReadLine();
            Console.WriteLine("Introduce la fecha de nacimiento: ");
            cliente.FchNacimientoCliente = Console.ReadLine();
            Console.WriteLine("Introduce el email para el cliente: ");
            cliente.EmailCliente = Console.ReadLine();
            Console.WriteLine("Introduce el teléfono de contacto: ");
            cliente.TlfCliente = Convert.ToInt32(Console.ReadLine());
            cliente.FchAltaCliente = Convert.ToString(DateTime.Now);
            /*Declaro la varible como null porque al darse de alta como nuevo
            cliente no puede haber ninguna fecha de baja*/
            cliente.FchBajaCliente = Convert.ToString(null);

            //Guardo el cliente en la lista
            listaAntigua.Add(cliente);

            Console.WriteLine(cliente.ToString());
        }
    }
}

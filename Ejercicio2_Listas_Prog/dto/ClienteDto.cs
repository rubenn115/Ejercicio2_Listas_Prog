//Ruben Bernal Ramos, CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Listas_Prog.dto
{
    /// <summary>
    /// Clase que utilizaré como tipo objeto para añadir los clientes
    /// rbr - 141123
    /// </summary>
    internal class ClienteDto
    {
        //Declaro los atributos
        string nombreCliente;
        string apellidosCliente;
        string dniCliente;
        string fchNacimientoCliente;
        string emailCliente;
        int tlfCliente;
        string fchAltaCliente;
        string fchBajaCliente;

        //Getters y Setters
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FchNacimientoCliente { get => fchNacimientoCliente; set => fchNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }

        //Método ToString
        public string ToString()
        {
            string clienteDto = "Nombre y apellidos: " + this.nombreCliente + " " + this.apellidosCliente +
                "   Dni: " + this.dniCliente + "\n" +
                "   Fecha de nacimiento: " + this.fchNacimientoCliente +
                "   Email: " + this.emailCliente + "\n" +
                "   Teléfono: " + this.tlfCliente +
                "   Fecha de alta: " + this.fchAltaCliente;

            return clienteDto;
        }

        //Constructores
        public ClienteDto(string nombreCliente, string apellidosCliente, string dniCliente, string fchNacimientoCliente, string emailCliente, int tlfCliente, string fchAltaCliente)
        {
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fchNacimientoCliente = fchNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchAltaCliente = fchAltaCliente;
        }

        public ClienteDto()
        {

        }
    }
}

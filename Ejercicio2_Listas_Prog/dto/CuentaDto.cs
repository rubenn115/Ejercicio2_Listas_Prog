//Ruben Bernal Ramos, CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Listas_Prog.dto
{
    /// <summary>
    /// Clase que utilizaré como tipo objeto para añadir las cuentas bancarias
    /// rbr - 221123
    /// </summary>
    internal class CuentaDto
    {
        //Declaro los atributos
        int id;
        string isban;
        string codigoSwitch = "CSI1SSXX";
        string fechaAlta;
        string fechaBaja;
        string identificadorCliente;

        //Getters y Setters
        public int Id { get => id; set => id = value; }
        public string Isban { get => isban; set => isban = value; }
        public string CodigoSwitch { get => codigoSwitch; set => codigoSwitch = value; }
        public string FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public string IdentificadorCliente { get => identificadorCliente; set => identificadorCliente = value; }

        //Método ToString
        public string ToString()
        {
            string cuentaDto = "Id: " + this.id + " " +
                "   Isban: " + this.isban + "\n" +
                "   Código switch: " + this.codigoSwitch +
                "   Fecha de alta: " + this.fechaAlta + "\n" +
                "   Fecha de baja: " + this.fechaBaja +
                "   Identificador del cliente: " + this.identificadorCliente;

            return cuentaDto;
        }

        //Constructores
        public CuentaDto(int id, string isban, string codigoSwitch, string fechaAlta, string fechaBaja, string identificadorCliente)
        {
            this.id = id;
            this.isban = isban;
            this.codigoSwitch = codigoSwitch;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            this.identificadorCliente = identificadorCliente;
        }

        public CuentaDto()
        {

        }
    }
}

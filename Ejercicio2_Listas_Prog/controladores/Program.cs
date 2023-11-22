// Ruben Bernal Ramos, CSI1

using Ejercicio2_Listas_Prog.dto;
using Ejercicio2_Listas_Prog.servicios;

namespace Ejercicio2_Listas_Prog.controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// rbr - 141123
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// rbr - 141123
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Declaro la variable opcion
            int opcion;

            //Declaro las listas
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<CuentaDto> listaCuentas = new List<CuentaDto>();

            //Instancio las interfaces con sus implementaciones
            MenuInterfaz mi = new MenuImplementacion();
            RegistrarInterfaz ri = new RegistrarImplementacion();
            NuevaCuentaInterfaz ni = new NuevaCuentaImplementacion();

            //Creo el objeto cliente
            ClienteDto cliente = new ClienteDto();

            do
            {
                //Muestro el menú por consola
                mi.menu();

                //Solicito la opción a elegir por consola
                Console.WriteLine("Introduce la opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                //Accedo al apartado correspondiente teniendo en cuenta la opción introducida
                switch (opcion)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Has seleccionado la opción de registro de cliente");
                        ri.solicitudDatos(listaClientes);
                        break;
                    case 2:
                        Console.WriteLine("Has seleccionado la opción para crear una nueva cuenta bancaria");
                        ni.solicitarDatos(listaCuentas);
                        break;
                    default:
                        Console.WriteLine("*** ERROR. La opción introducida no es válida ***");
                        break;
                }
            } while (opcion != 0);
        }
    }
}
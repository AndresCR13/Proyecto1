using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Menu
    {
        //declararcion  de la variable opcion y que pueda ser usada en todo el sistema
        public static int opcion;

        // metodo para el menu
        public static void menu()
        {
            // bucle que al menos se ejecuta una vez que muestra el menú principal
            do
            {
                Console.WriteLine("1- Inicializar Vectores");
                Console.WriteLine("2- Realizar Pagos");
                Console.WriteLine("3- Consultar Pagos");
                Console.WriteLine("4- Modificar Pagos");
                Console.WriteLine("5- Eliminar Pagos");
                Console.WriteLine("6- Submenú Reportes");
                Console.WriteLine("7- Salir");
                Console.WriteLine("Digite una opción del menú");

                string input = Console.ReadLine();

                /* el if con el int.TryParse es para verificar que sea un numero
                 si es correcto se ejecutará el switch
                de lo contrario mostrará un mensaje diciendo que ingrese un numero*/

                if (int.TryParse(input, out opcion))
                {
                    switch (opcion)
                    {
                        case 1: Console.WriteLine("Opción 1"); break;
                        case 2: Console.WriteLine("Opción 2"); break;
                        case 3: Console.WriteLine("Opción 3"); break;
                        case 4: Console.WriteLine("Opción 4"); break;
                        case 5: Console.WriteLine("Opción 5"); break;
                        case 6: Menu.Submenu(); break;
                        case 7: Console.WriteLine("Opción 7"); break;
                        default: Console.WriteLine("Digite una opción válida"); break;
                    }
                }
                else
                {
                    Console.WriteLine("La opción ingresada no es válida. Por favor, ingrese un número.");
                }

            } while (opcion != 7); // el bucle continuara hasta que la opcion sea 7
        }
        // metodo para el submenu de la opcion 6
        public static void Submenu()
        {
            do
            {
                Console.WriteLine("1- Ver todos los pagos");
                Console.WriteLine("2- Ver pagos por tipo de servicio");
                Console.WriteLine("3- Ver pagos por código de caja");
                Console.WriteLine("4- Ver dinero comisionado por servicios");
                Console.WriteLine("5- Regresar al menú principal");
                Console.WriteLine("Digite una opción");

                string subInput = Console.ReadLine();
                if (int.TryParse(subInput, out int submenuOp))
                {
                    switch (submenuOp)
                    {
                        case 1: Console.WriteLine("pago 1"); break;
                        case 2: Console.WriteLine("pago 2"); break;
                        case 3: Console.WriteLine("pago 3"); break;
                        case 4: Console.WriteLine("pago 4"); break;
                        case 5: Console.WriteLine("Volviendo al menú principal"); return;
                        default: Console.WriteLine("Digite una opcion valida"); break;
                    }
                }
                else
                {
                    Console.WriteLine("La opción no es correcta. Ingrese un numero ");
                }
            } while (true);
        }
    }
}


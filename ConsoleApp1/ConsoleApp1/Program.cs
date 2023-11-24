using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("GESTION DE EMPLEADOS ");
            Console.WriteLine("------------------------");
            // Solicitar al usuario que ingrese los datos para el Empleado
            Console.Write("Ingrese el nombre del empleado: ");
            string nombreEmpleado = Console.ReadLine();

            Console.Write("Ingrese el salario del empleado: ");
            double salarioEmpleado = Convert.ToDouble(Console.ReadLine());

            // Crear instancia de Empleado con los datos ingresados
            Empleado empleado = new Empleado(nombreEmpleado, salarioEmpleado);

            // Solicitar al usuario que ingrese los datos para el Gerente
            Console.Write("Ingrese el nombre del gerente: ");
            string nombreGerente = Console.ReadLine();

            Console.Write("Ingrese el salario del gerente: ");
            double salarioGerente = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el departamento del gerente: ");
            string departamentoGerente = Console.ReadLine();

            // Crear instancia de Gerente con los datos ingresados
            Gerente gerente = new Gerente(nombreGerente, salarioGerente, departamentoGerente);

            // Mostrar información utilizando polimorfismo a través de la interfaz
            Console.WriteLine("\nInformación del Empleado:");
            MostrarInformacion(empleado);

            Console.WriteLine("\nInformación del Gerente:");
            MostrarInformacion(gerente);

            // Esperar la entrada del usuario antes de cerrar la consola
            Console.WriteLine("\nPresiona Enter para salir...");
            Console.ReadLine();
        }

        // Método que acepta cualquier objeto que implemente la interfaz IMostrarInformacion
        static void MostrarInformacion(IMostrarInformacion objeto)
        {
            objeto.MostrarInformacion();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    // Definición de la clase Empleado
    public class Empleado : IMostrarInformacion
    {
        // Atributos
        public string Nombre { get; set; }
        public double Salario { get; set; }

        // Constructor
        public Empleado(string nombre, double salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

        // Método para calcular el salario anual
        public double CalcularSalarioAnual()
        {
            return Salario * 12;
        }

        // Implementación del método de la interfaz
        public void MostrarInformacion()
        {
            Console.WriteLine($"| Empleado  | Nombre: {Nombre,-10} | Salario Mensual: {Salario,-10:C} | Salario Anual: {CalcularSalarioAnual():C} |");
        }
    }
}

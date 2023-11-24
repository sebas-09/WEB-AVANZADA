using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    // Definición de la clase Gerente que hereda de Empleado
    public class Gerente : Empleado, IMostrarInformacion
    {
        // Nuevo atributo para el departamento
        public string Departamento { get; set; }

        // Constructor
        public Gerente(string nombre, double salario, string departamento)
            : base(nombre, salario)
        {
            Departamento = departamento;
        }

        // Implementación del método de la interfaz
        public new void MostrarInformacion()
        {
            Console.WriteLine($"| Gerente   | Nombre: {Nombre,-10} | Salario Mensual: {Salario,-10:C} | Salario Anual: {CalcularSalarioAnual():C} | Departamento: {Departamento,-10} |");
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller_individual
{
    internal class empleado
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del empleado: ");
            String Nombre = Console.ReadLine();

            Console.Write("Ingrese el codigo del empledo: ");
            int codigoEmpleado =Convert.ToInt32( Console.ReadLine());

            Console.Write("Ingresa las horas laboradas: ");
            double horas =Convert.ToDouble (Console.ReadLine());

            Console.Write("Ingrese el valor de la hora: ");
            double ValorHora = Convert.ToDouble(Console.ReadLine());

            double SalarioNeto = horas * ValorHora;

            Console.WriteLine($"El salario neto de {Nombre} es:  + {SalarioNeto}");

            Console.WriteLine("El salario en pesos y redodeando a 2 decimales por encima: " + Math.Ceiling(SalarioNeto * 100 / 100));

            Console.WriteLine("El salario en pesos y redondeado al numero mas cercano y a 2 decimales: " + Math.Round(SalarioNeto, 2));

            // Verificar si el salario es mayor a 2 SMLV 
            double SalarioSmlv = 2600000;
            if (SalarioNeto > SalarioSmlv)
            {
                Console.WriteLine("No recibes ST");
            }
            else
            {
                Console.WriteLine("recibiras el ST");
            }
        }

    }
}

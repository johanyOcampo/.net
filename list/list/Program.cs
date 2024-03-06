using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> empleados = new List<string>();
            //AGREGAR DATOS A LA LIESTA
            empleados.Add("Johany");
            empleados.Add("Sofia");
            empleados.Add("Rodolfo");
            empleados.Add("Lorena");
            empleados.Add("Guillermo");

            //  Console.WriteLine(empleados[3]); //IMPRIMIR EL NOOMBRE DEL EMPLEADO  EN LA POSICION 3

            // empleados.Sort(); //ME ORGANIZA LOS ELEMENTOS DE LA LISTA

            empleados.Insert(1, "Alison"); //INSERTAR ELEMENTOS POR POSICION

            empleados.Remove("Lorena"); // ELIMINAR NOMBRE DE LA POSICION

            empleados.RemoveAt(4); //ELIMINAR LA POSICION

            //for (int i = 0; i < empleados.Count; i++) 
            // {
            //    Console.WriteLine(empleados[i]);
            // }

            foreach (String empleado in empleados)
            {
                Console.WriteLine(empleado);
            }
        }
    }
}

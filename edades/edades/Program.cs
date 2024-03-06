using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE LA EDAD DE LA PERSONA: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 0 && edad <= 5)
            {
                Console.WriteLine("Eres infante, tienes derecho a una merienda");
            }
            else if (edad >= 6 && edad <= 10)
            {
                Console.WriteLine("Eres un niño, ya puedes correr y hablar");
            }
            else if (edad >= 11 && edad <= 15)
            {
                Console.WriteLine("Eres preadolecente, ya puedes tener novia");
            }
            else if (edad >= 16 && edad <= 18)
            {
                Console.WriteLine("Eres adolecente, puedes conseguir tu primer trabajo");
            }
            else if (edad >= 19 && edad <= 25)
            {
                Console.WriteLine("eres preadulto, tienes que trabajar y ser responsable");
            }
            else if (edad <= 26 && edad <= 40)
            {
                Console.WriteLine("eres adulto");
            }
            else if (edad >= 41 && edad <= 55)
            {
                Console.WriteLine(" eres Preacioano");
            }
            else (edad >56) {
                Console.WriteLine("Eres anciano");
            }
            }
        }
    
}

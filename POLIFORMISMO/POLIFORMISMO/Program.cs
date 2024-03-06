using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIFORMISMO
{
    public class Program
    {
       public static void Main(string[] args)
        {
            //CREAR UN ARREGLO DE VEHICULO
            vehiculo[] misVehivulos = new vehiculo[4];

            //FIJAR UN VEHICULO EN MI ARREGLO INSTACIADO DESDE LA CLASE PADRE
            misVehivulos[0] = new vehiculo("GM56", "FERRARI", "2015");


            misVehivulos[1] = new VehiculoTurismo(4, "FM45", "MINI BAN", "2008");
            misVehivulos[2] = new VehiculoDeportivo(500, "45GM", "TOYOTA", "2024");
            misVehivulos[3] = new VehiculoFurgoneta(3000, "YT56", "CHEVROLET", "2000");

            foreach (vehiculo vehiculo in misVehivulos)
            {
                Console.WriteLine(vehiculo.mostrarDatos());
                Console.WriteLine("");
            }    
            
        }
        
    }
}

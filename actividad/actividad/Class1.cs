using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la venta de medellin: ");
            double VentaMedellin = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la venta de bogota: ");
            double VentaBogota = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la venta de cali: ");
            double VentaCali = Convert.ToDouble(Console.ReadLine());

            //CALCULAR TOTAL
            double TotalVentas = VentaMedellin + VentaBogota + VentaCali;

            //CALCULAR PROMEDIO

            int NumeroVentas = 3;
            double PromedioVentas = NumeroVentas / TotalVentas;

     

            Console.WriteLine("El total de las ventas es: " + Math.Abs(TotalVentas));
            Console.WriteLine("El promedio de las ventas es: " + Math.Abs(PromedioVentas));


            double VentaAlta = Math.Max(VentaMedellin, Math.Max (VentaBogota, VentaCali));
            double VentaBaja = Math.Min(VentaMedellin, Math.Min (VentaBogota, VentaCali));

            Console.WriteLine("La venta mas alta es: " +  VentaAlta);
            Console.WriteLine("La venta mas baja es: " + VentaBaja);
        }
    }
}

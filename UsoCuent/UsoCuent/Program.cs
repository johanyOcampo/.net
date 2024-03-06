using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCuent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaCorriente Cuenta1 = new CuentaCorriente(500, "Juan Gomez");
            CuentaCorriente Cuenta2 = new CuentaCorriente(2500, "Maria Lopez");
            //LE PASAMOS LOS DATOS DE CADA CUENTA POR PARAMETRO, DE UNA SACAMOS Y LLEVAMOS A OTRA

            CuentaCorriente.Transferencia(Cuenta1, Cuenta2, 200);
            //PEDIMOS LOS DATOS DE CADA CUENTA PARA VER EL SALDO
            Console.WriteLine(Cuenta1.getDatosCuenta());
            Console.WriteLine(Cuenta2.getDatosCuenta());
        }
    }
}

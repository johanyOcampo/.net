using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCuent
{
    internal class CuentaCorriente
    {
        //VARIABLES PRIVADAS
        private double saldo;
        private String NombreTitular;
        private long NumeroCuenta;

        //LLAMAMOS CONSTRUCTOR
        public CuentaCorriente(double saldo, string nombreTitular)
        {
            this.saldo = saldo;
            this.NombreTitular = nombreTitular;
            Random rnd = new Random();
            NumeroCuenta = Math.Abs(rnd.Next());
        }

        //METODO SETTER PARA REALIZAR PAGOS
        public void setIngreso(double ingreso)
        {
            if (ingreso < 0)
            {
                Console.WriteLine("No se permiten ingresos negativos");
            }
            else
            {
                saldo += ingreso;
            }
        }

        //METODO SETTER PARA REALIZAR RETIROS/SALIDAS
        public void setRetiro(double retiro)
        {
            saldo -= retiro;
        }

        // METODO  GETTER PARA OBTENER SALDO Y DATOS GENERALES DE LA CUENTA
        private String getSaldo()
        {
            return ("el slado de la cuenta es: " + saldo);
        }
        //METODO ADICIONAL PARA REALIZAR TRANSFERENCIAS
        public static void Transferencia(CuentaCorriente titul1, CuentaCorriente titul2, double cantidad)
        {
            titul2.saldo += cantidad;
            titul1.saldo -= cantidad;
        }

        //TRAER LOS DATOS DEL TITULAR
        public String getDatosCuenta()
        {
            return "titular : " + NombreTitular + "\n" +
                "Nro cuenta: " + NumeroCuenta + "\n" + "saldo: " + saldo;
        }
    }
}

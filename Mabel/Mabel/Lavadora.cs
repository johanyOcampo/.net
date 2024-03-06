using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;

namespace Mabel
{
    internal class Lavadora
    {
        //private string nombreRopa;
        private int kilos;
        private int tiempoLavado;
        private List<string> tiposDeRopa;



        //Constructor 
        public Lavadora(List<string> tiposDeRopa, int kilos, int tiempoLavado)
        {

            this.tiposDeRopa = tiposDeRopa;
            this.kilos = kilos;
            this.tiempoLavado = tiempoLavado;
        }

        public Lavadora() { }



        protected int Kilos
        {
            get { return Kilos; }
            set { Kilos = value; }
        }

        protected int TiempoLavado
        {
            get { return tiempoLavado; }
            set { tiempoLavado = value; }
        }

        protected List<string> TiposDeRopa
        {
            get { return tiposDeRopa; }
            set { tiposDeRopa = value; }
        }

        //protected string NombreTipoRopa
        //{
        //    get { return nombreTipoRopa; }
        //    set { nombreTipoRopa = value; }
        //}

        public override string ToString()
        {
            string tiposRopaString = (tiposDeRopa != null && tiposDeRopa.Any()) ? string.Join(", ", tiposDeRopa) : "Ninguno";
            return $"Ropa en kilos: {kilos}, Tiempo de lavado: {tiempoLavado} minutos, Tipos de ropa: {tiposRopaString}";
        }

        public void InicioLavadora()
        {
           

            foreach (char letra in "Encendida \n")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(letra);
                Console.ResetColor();
                Thread.Sleep(100);
            }

        }

        private void DatosLavado()
        {
            bool entradaValida = false;

            do
            {
                Console.WriteLine("Ingrese los kilos de ropa a lavar: ");
                string input = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Por favor, ingrese un valor.");
                }
                else if (!int.TryParse(input, out kilos))
                {
                    Console.WriteLine("Por favor, ingrese un valor numérico.");
                }
                else if (kilos < 10 || kilos > 30)
                {
                    Console.WriteLine("Ingrese los kilos correctos, MIN 10/MAX 30");
                }
                else
                {
                    entradaValida = true;
                }
            } while (!entradaValida);

        }




        //Lista para almacenar los tipos de ropa
        private List<string> listaTipoRopa()
        {
            List<string> tiposDeRopa = new List<string>();

            Console.WriteLine("Ingrese los tipos de ropa a lavar (escriba 'fin' para terminar):");

            string tipoRopa;
            do
            {
                tipoRopa = Console.ReadLine().Trim();

                if (tipoRopa.ToLower() != "fin")
                {
                    tiposDeRopa.Add(tipoRopa);
                }
            }
            while (tipoRopa.ToLower() != "fin");

            Console.WriteLine("Recomendaciones de Lavado!");
            Console.WriteLine("1. Agua fría (hasta 20 º): se recomienda para ropa de colores, algodón, lycra, sedas, prendas delicadas y telas que puedan achicarse.");
            Console.WriteLine("2 Agua tibia (entre 30 a 50º): se recomienda para jeans, camperas, ropa muy sucia o poco delicada.");
            Console.WriteLine("3. Agua caliente (entre 55 a 90º): se recomienda para toallas, sábanas o acolchados, telas blancas gruesas y cortinas de tela.");

            foreach (string tipo in tiposDeRopa)
            {
                Console.WriteLine($"Para '{tipo}', la opción de lavado recomendada es:");
                if (tipo.Contains("algodón") || tipo.Contains("lycra") || tipo.Contains("sedas") || tipo.Contains("prendas delicadas"))
                {
                    Console.WriteLine("SE RECOMIENDA: Agua fría (hasta 20 º)");
                }
                else if (tipo.Contains("jeans") || tipo.Contains("camperas") || tipo.Contains("ropa muy sucia"))
                {
                    Console.WriteLine("SE RECOMIENDA: Agua tibia (entre 30 a 50º)");
                }
                else if (tipo.Contains("toallas") || tipo.Contains("sábanas") || tipo.Contains("acolchados") || tipo.Contains("telas blancas gruesas") || tipo.Contains("cortinas de tela"))
                {
                    Console.WriteLine("SE RECOMIENDA: Agua caliente (entre 55 a 90º)");
                }
                else
                {
                    Console.WriteLine("No hay recomendación específica para este tipo de ropa.");
                }
            }



            return tiposDeRopa;
        }


        //Metodo llenado
        private void llenadoAgua()
        {

            


            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Llenando...");
                Console.Beep(1000,500);

            }
        
            Console.WriteLine("Llenado completado.");
            Console.ResetColor();
        }

        //Metodo lavado
        private void lavado()
        {
            

            Console.WriteLine("¿La ropa está muy sucia? (SI/NO)");
            string respuestaRopa = Console.ReadLine().ToLower();

            if (respuestaRopa == "si")
            {
                Console.WriteLine("Ingrese el tiempo de lavado en minutos:");
                if (int.TryParse(Console.ReadLine(), out int tiempo))
                {
                    if (tiempo > 0)
                    {
                        tiempoLavado = tiempo;
                        Console.WriteLine($"Tiempo de lavado fijado en {tiempoLavado} minutos.");
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un valor de tiempo de lavado válido (mayor que 0).");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un valor numérico para el tiempo de lavado.");
                }
            }
            else if (respuestaRopa == "no")
            {
                Console.WriteLine("Tiempo fijado para lavado general.");
            }
            else
            {
                Console.WriteLine("Respuesta no reconocida. Por favor, ingrese 'SI' o 'NO'.");
            }

            for (int i = 0; i < 3; i++)
            {
               
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Lavando...");
                Console.Beep(1000, 500);


            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Lavado Completado.");
            Console.ResetColor();

        }


        //Metodo enjuague y secado
        private void EnjuagueSecado()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enjuagando Ropa...");
                Console.Beep(1000, 500);
                Thread.Sleep(500);
                

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ropa Enjuagada!.");

            // Preguntamos al usuario si desea secar o detener
            string respuestaSecar;
            do
            {
                Console.WriteLine("Desea seguir con el proceso de secado? SI/NO ");
                respuestaSecar = Console.ReadLine().ToLower();

                if (respuestaSecar == "si")
                {
                    // Continuar con el proceso de secado
                    Console.WriteLine("Continuar proceso de secado...");
                    // Aquí puedes agregar el código para el ciclo de secado
                    // y cualquier otra tarea necesaria
                }
                else if (respuestaSecar == "no")
                {
                    // Se detiene el proceso y se espera que el usuario ingrese R para continuar
                    Console.WriteLine("Proceso pausado, ingrese 'R' para reanudar el proceso");
                    string reanudar = Console.ReadLine().ToLower();

                    while (reanudar != "r")
                    {
                        Console.WriteLine("Opción no válida. Por favor, ingrese 'R' para reanudar el proceso");
                        reanudar = Console.ReadLine().ToLower();
                    }

                    // Si el usuario decide reanudar, se sale del bucle y continúa con el proceso de secado
                    for (int i = 0; i < 3; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Secando Ropa...");
                        Console.Beep(1000, 500);
                        Thread.Sleep(500);

                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Secado Completado.");
                    Console.ResetColor();
                }
                else
                {
                    // Respuesta no válida, pedir al usuario que ingrese nuevamente
                    Console.WriteLine("Respuesta no válida. Por favor, ingrese 'SI' o 'NO'.");
                }
            } while (respuestaSecar != "si");


        }

        //Metodo ciclo terminado, disponible para importar
        public static void lavadoTerminado()
        {
            bool continuar = true;
            // Creamos una instancia de Lavadora
            // Bucle para permitir múltiples registros
            while (continuar)
            {
                // Creamos una instancia de Lavadora
                Lavadora lavadora = new Lavadora();

                // Llamamos a los diferentes métodos para realizar el lavado
                lavadora.InicioLavadora();
                lavadora.DatosLavado();
                List<string> tiposDeRopa = lavadora.listaTipoRopa(); // Almacenamos los tipos de ropa ingresados
                lavadora.llenadoAgua();
                lavadora.lavado();
                lavadora.EnjuagueSecado();

                // Creamos una nueva instancia de Lavadora pasando los tipos de ropa ingresados como argumento al constructor
                Lavadora lavada1 = new Lavadora(tiposDeRopa, lavadora.kilos, lavadora.tiempoLavado );

                // Mostramos los detalles de la lavadora
                Console.WriteLine(lavada1.ToString());

                Console.WriteLine("Ingrese el nombre del cliente");
                string cliente = Console.ReadLine();
                lavada1.Facturacion(cliente);

                // Preguntamos al usuario si desea continuar o salir del programa
                Console.WriteLine("¿Desea ingresar otro registro? (SI/NO)");
                string respuesta = Console.ReadLine().ToLower();

                // Si la respuesta es NO, actualizamos la variable continuar a false para salir del bucle
                if (respuesta != "si")
                {
                    continuar = false;
                }
            }
        }


        private void Facturacion(string nombreCliente)
        {

            double costoPorKilo = 4000;


            if (tiposDeRopa.Any(tipo => tipo.Contains("color") || tipo.Contains("algodón")))
            {
                costoPorKilo *= 0.05;
            }


            double costoLavado = kilos * costoPorKilo;
            double costoTotalCliente = costoLavado * 1.19;
            double gananciaDueño = costoLavado * 0.3;
            double totalDinero = costoLavado + gananciaDueño;

            double potencia = 2000; // Supongamos que la potencia es de 2000 W (2 kW)
            double tiempoEnHoras = TiempoLavado / 60.0; // Convertimos el tiempo de lavado de minutos a horas
            double kwhConsumidos = potencia * tiempoEnHoras / 1000; // Calculamos los kWh consumidos

            // Calculando el costo de la energía eléctrica consumida
            double costoKwh = 516.72; // Costo por kWh
            double costoEnergia = kwhConsumidos * costoKwh;

            Console.WriteLine($"Cantidad de kWh consumidos: {kwhConsumidos} kWh");
            Console.WriteLine($"Costo de la energía eléctrica consumida: ${costoEnergia}");


            // Mostrando los resultados
            Console.WriteLine($"Nombre del cliente: {nombreCliente}");
            Console.WriteLine($"Fecha y hora del lavado: {DateTime.Now}");
            Console.WriteLine($"Costo de lavar {kilos} kilos de ropa: ${costoLavado}");
            Console.WriteLine($"Costo total de lavado para el cliente (IVA incluido): ${costoTotalCliente}");
            Console.WriteLine($"Ganancia del dueño: ${gananciaDueño}");
            Console.WriteLine($"Total de dinero realizado en la operación de lavado: ${totalDinero}");
            Console.WriteLine();

            // Incrementando el contador de clientes atendidos
            // clientesAtendidos++;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerEstructuras
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("BIENVENIDO AL GYM");
            //CONTADOR DE LOS CLIENTES
            int clientesAtendidos = 0;

            while (true)
            {
                string nombre = "";
                int documento = 0;
                string fechaNacimiento = "";
                int edad = 0;
                string modalidadPago = "";
                double peso = 0.0;
                double estatura = 0.0;
                double imc = 0.0;
                string enfermedad = "";
                string cormobilidad = "";
                string mensaje = "";

                //SOLICITAR DATOS

                Console.Write("INGRESE SU NOMBRE: ");

                try
                    {
                        nombre = Console.ReadLine();
                        
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Ingrese un nombre válido ");
                    }

                Console.Write("INGRESE SU DOCUMENTO: ");
                bool documentoValido = false;
                while (!documentoValido)
                {
                    try
                    {
                        documento = Convert.ToInt32(Console.ReadLine());
                        documentoValido = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Ingrese un documento válido.");
                    }
                }

                Console.Write("INGRESE SU FECHA DE NACIMIENTO (YYYY-MM-DD): ");
                fechaNacimiento = Console.ReadLine();

                Console.Write("INGRESE SU EDAD: ");
                bool edadValida = false;
                while (!edadValida)
                {
                    try
                    {
                        edad = Convert.ToInt32(Console.ReadLine());
                        edadValida = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Ingrese una edad válida.");
                    }
                }

                //VALIDACION DE LA EDAD
                if (edad < 15)
                {
                    Console.WriteLine("No puedes entrar al gym, eres muy menor");
                    continue;
                }

                //VALIDACION DE LA CONFORMIDAD
                Console.Write("¿TIENE ALGUNA CONFORMIDAD? S/N: ");
                string respuesta = Console.ReadLine().ToUpper();
                if (respuesta == "S")
                {
                    Console.Write("CUAL ES SU CONFORMIDAD?:  ");
                    enfermedad = Console.ReadLine();
                    Console.WriteLine("Asignar un instructor especial");
                    mensaje = Console.ReadLine();
                    cormobilidad = enfermedad;
                }

                //FECHA Y HORA REGISTRO
                DateTime fechaMatricula = DateTime.Now;
                Console.WriteLine("La fecha de la matrícula es: " + fechaMatricula);

                //VARIABLES DE MENSUALIDAD
                double valorMensualidad = 70000;
                double totalPagar = 0;
                double descuento = 10;

                Console.Write("COMO DESEA PAGAR (contado/tarjeta):  ");
                bool modalidadPagoValida = false;
                while (!modalidadPagoValida)
                {
                    modalidadPago = Console.ReadLine().ToLower();
                    try
                    {
                        //VALIDACION DEL PAGO
                        if (modalidadPago == "contado" || modalidadPago == "tarjeta")
                        {
                            if (modalidadPago == "contado")
                            {
                                descuento = (valorMensualidad * 10) / 100;
                                totalPagar = valorMensualidad - descuento;
                            }
                            else if (modalidadPago == "tarjeta")
                            {
                                totalPagar = valorMensualidad;
                            }
                            modalidadPagoValida = true;
                        }
                        else
                        {
                            throw new FormatException();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Ingrese una modalidad de pago válida (contado/tarjeta).");
                    }
                }

                Console.Write("INGRESE SU PESO: ");
                bool pesoValido = false;
                while (!pesoValido)
                {
                    try
                    {
                        peso = Convert.ToDouble(Console.ReadLine());
                        pesoValido = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Ingrese un peso válido.");
                    }
                }

                Console.Write("INGRESE SU ESTATURA: ");
                bool estaturaValida = false;
                while (!estaturaValida)
                {
                    try
                    {
                        estatura = Convert.ToDouble(Console.ReadLine());
                        estaturaValida = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Ingrese una estatura válida.");
                    }
                }


                // CALCULAR EL IMC
                imc = peso / Math.Pow(estaturaMetros, 2);

                //VARIABLES PARA DIAGNOSTICO Y RECOMENDACION
                string diagnostico = "";
                string recomendacion = "";

                //VALIDACION DEL IMC
                if (imc < 16.00)
                {
                    diagnostico = "Delgadez Severa";
                    recomendacion = "Su peso es demasiado bajo - Consulte su médico.";
                }
                else if (imc >= 16.00 && imc <= 16.99)
                {
                    diagnostico = "Delgadez Moderada";
                    recomendacion = "Su peso es bajo - Incluya calorías y carbohidratos en su dieta.";
                }
                else if (imc >= 17.00 && imc <= 18.49)
                {
                    diagnostico = "Delgadez Leve";
                    recomendacion = "Su peso es ligeramente bajo - Mejore sus hábitos alimenticios.";
                }
                else if (imc >= 18.50 && imc <= 24.99)
                {
                    diagnostico = "Normal";
                    recomendacion = "Usted tiene un peso saludable.";
                }
                else if (imc >= 25.00 && imc <= 29.99)
                {
                    diagnostico = "Preobeso";
                    recomendacion = "Su peso es levemente alto - Procure hacer ejercicio.";
                }
                else if (imc >= 30.00 && imc <= 34.99)
                {
                    diagnostico = "Obesidad Leve";
                    recomendacion = "Su peso es alto - Controle su dieta y realice ejercicio.";
                }
                else if (imc >= 35.00 && imc <= 39.99)
                {
                    diagnostico = "Obesidad Media";
                    recomendacion = "Su peso es muy alto - Visite a su médico y controle su dieta.";
                }
                else if (imc > 40)
                {
                    diagnostico = "Vaya a su EPS primero";
                }

                //IMPRIMIR TODOS LOS DATOS
                Console.WriteLine($"Datos personales: su nombre es: {nombre}, su documento es {documento}, su fecha de nacimiento es {fechaNacimiento}, " +
                    $"su edad es {edad}, su peso es de {peso} kilos, y su estatura es de {estatura} cm");
                Console.WriteLine($"Usted escogió pagar de forma {modalidadPago} y el total a pagar es {totalPagar}");
                Console.WriteLine($"Su IMC es de {imc} y el diagnóstico es {diagnostico} y nuestra recomendación es de {recomendacion}");
                Console.WriteLine($"Su comorbilidad es: {cormobilidad}");
                Console.WriteLine(mensaje);

                // Incrementar el contador de clientes atendidos
                clientesAtendidos++;

                Console.WriteLine("El total de personas atendidas del día hoy son: " + clientesAtendidos);
                Console.Write("¿Hay más clientes por atender? (S/N): ");
                string respuesta2 = Console.ReadLine().ToUpper();
                if (respuesta2 != "S")
                {
                    break; // Salir del bucle si no hay más clientes
                }
            }
        }
    }
}

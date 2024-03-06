//BIENVENIDA AL PROGRAMA
Console.WriteLine("BIENVENIDO AL GYM");
//CONTADOR DE LOS CLIENTES
int clientesAtendidos = 0;

//BUCLE PARA PODER SEGUIR REGISTRANDO CLIENTES
while (true)
{
    //SOLICITAR DATOS
    

    Console.Write("INGRESE SU NOMBRE: ");
    string nombre = Console.ReadLine();


    Console.Write("INGRESE SU DOCUMENTO: ");
    if (!int.TryParse(Console.ReadLine(), out int documento))
    {
        Console.WriteLine("Ingrese un número de documento válido.");
        continue;
    }

    Console.Write("INGRESE SU FECHA DE NACIMIENTO (YYYY-MM-DD): ");
    var fechaNacimiento = Console.ReadLine();

    Console.Write("INGRESE SU EDAD: ");
    int edad = Convert.ToInt32(Console.ReadLine());

    //VALLIDACION DE LA EDAD
    if (edad < 15)
    {
        Console.WriteLine("no puedes entrar al gym, eres muy menor");
        continue;
    }


    //VAALIDACION DE LA CONFORMIDAD
    Console.Write("TIENES ALGUNA CONFORMIDAD? S/N ");
    bool respuesta = Console.ReadLine().ToUpper() == "S";
    string cormobilidad = "";
    string mensaje = "";
    if (respuesta)
    {
        Console.Write("CUAL ES SU CONFORMIDAD?:  ");
        string  enfermedad = Console.ReadLine();
        Console.WriteLine("Asignar un intructor especial");
        mensaje = Console.ReadLine();
        cormobilidad = enfermedad;
    }
  

    //FECHA Y HORA REGISTRO
    DateTime FechaMatricula = DateTime.Now;
    Console.WriteLine("La fecha de la matricula es: " + FechaMatricula);

    //VARIABLES DE MENSUALIDAD
    double ValorMensualidad = 70000;
    double TotalPagar = 0;
    double descuento = 10;

    Console.WriteLine("COMO DESEA PAGAR (contado/tarjeta):  ");
    string ModalidadPago = Console.ReadLine();

    //VALIDACION DEK PAGO
    if (ModalidadPago == "contado" )
    {
         descuento = (ValorMensualidad * 10) / 100;
         TotalPagar = ValorMensualidad - descuento;
    }
    else if (ModalidadPago == "tarjeta")
    {
         TotalPagar = ValorMensualidad;
    }

    Console.Write("INGRESE SU PESO: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    Console.Write("INGRESE SU ESTATURA: ");
    double estatura = Convert.ToDouble(Console.ReadLine());

    // CONVERTIR ESTATURA DE CM A METROS
    double estaturaMetros = estatura / 100;

    //  CALCULAR EL IMC
    double imc = peso / (estaturaMetros * estaturaMetros);

    //VARIABLES PARA DIAGOSTICO Y RECOMENDACION
    string diagnostico = "";
    string recomendacion = "";

    //VALIDACION DEL IMC
     if ( imc < 16.00 ){
         diagnostico = "Delgadez Severa";
         recomendacion = "Su peso es demasiado bajo - Consulte su médico.";
    }
    else if (imc >= 16.00 || imc <= 16.99)
    {
         diagnostico = "Delgadez Moderada";
         recomendacion = "Su peso es bajo - Incluya calorías y carbohidratos en su dieta.";
    }
    else if (imc >= 17.00 || imc <= 18.49)
    {
         diagnostico = "Delgadez Leve";
         recomendacion = "Su peso es ligeramente bajo - Mejore sus hábitos alimenticios.";
    }
    else if (imc >= 18.50 || imc <= 24.99)
    {
         diagnostico = "Normal";
         recomendacion = "Usted tiene un peso saludable.";
    }
    else if (imc >= 25.00 || imc <= 29.99)
    {
         diagnostico = "Preobeso";
         recomendacion = "Su peso es levemente alto - Procure hacer ejercicio.";
    }
    else if (imc >= 30.00 || imc <= 34.99)
    {
         diagnostico = "Obesidad Leve";
         recomendacion = "Su peso es alto - Controle su dieta y realice ejercicio.";
    }
    else if (imc >= 35.00 || imc <= 39.99)
    {
         diagnostico = "Obesidad Media";
         recomendacion = "Su peso es muy alto - Visite a su médico y controle su dieta.";
    }
    else if (imc > 40)
    {
         diagnostico = "vaya a su EPS primero";
    }

    //IMPRIMIR TODOS LOS DATOS
    Console.WriteLine($"Datos personales: su nombre es: {nombre}, su documento es {documento},su fecha de nacimienro es {fechaNacimiento}, " +
        $"su edad es {edad}, su es de {peso} kilos, y su estatura es de {estatura} cm");
    Console.WriteLine($"Usted escogio pagar de forma {ModalidadPago} y el total a pagar es {TotalPagar}");
    Console.WriteLine($"Su IMC es de {imc} y el diagnostico es {diagnostico} y nustra recomendacion es de {recomendacion}");
    Console.WriteLine($"Su cormobilidad es: {cormobilidad}");
    Console.WriteLine(mensaje);




    // Incrementar el contador de clientes atendidos
    clientesAtendidos++;

    Console.WriteLine("El total de personas atendidad del dia hoy son: " + clientesAtendidos);
  
     




    Console.Write("¿Hay más clientes por atender? (S/N): ");
    string respuesta2 = Console.ReadLine().ToUpper();
    if (respuesta2 != "S")
    {
        break; // Salir del bucle si no hay más clientes
    }

}







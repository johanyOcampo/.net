//BIENVENIDA AL PROGRAMA
Console.WriteLine("BIENVENIDO A LA TIENDA DE TECNOLOGIA");
//PREGUNTAR AL USUARIO LA OPCION 
Console.Write("INGRESE UNA OPCION CORRECTA:  1-6");

Console.WriteLine("1. Teclado inalámbrico");
Console.WriteLine("2. Mause inalambrico");
Console.WriteLine("3. DRON con cámara");
Console.WriteLine("4. Tablet Huawei");
Console.WriteLine("5. Portátil Lenovo E480");
Console.WriteLine("6. Xbox 360");

int opcion = Convert.ToInt32(Console.ReadLine());


switch (opcion)
{
    case 1:
        int valorProducto1 = 32000;
        double descuento1 = (valorProducto1 * 3) / 100;
        double totalPagar1 = valorProducto1 - descuento1;
        Console.WriteLine($"el Teclado inalámbrico tiene el valor de {valorProducto1} con el descuento te queda en {totalPagar1}");
     break;

    case 2:
        int valorProducto2 = 25000;
        double descuento2 = 0;
        double totalPagar2 = valorProducto2 - descuento2;
        Console.WriteLine($"el mause inalámbrico tiene el valor de {valorProducto2} con el descuento te queda en {totalPagar2}");
     
    break;

    case 3:
        int valorProducto3 = 10000;
        double descuento3 = (valorProducto3 * 5) / 100;
        double totalPagar3 = valorProducto3 - descuento3;
        Console.WriteLine($"el DRON con cámara tiene el valor de {valorProducto3} con el descuento te queda en {totalPagar3}");
     break;

    case 4:
        int valorProducto4 = 155000;
        double descuento4 = (valorProducto4 * 8) / 100;
        double totalPagar4 = valorProducto4 - descuento4;
        Console.WriteLine($"el Tablet Huawei  tiene el valor de {valorProducto4} con el descuento te queda en {totalPagar4}");
        break;

    case 5:
        int valorProducto5 = 1345000;
        double iva1 = (valorProducto5 * 19) / 100;
        double totalPagar5 = valorProducto5 + iva1;
        Console.WriteLine($"el Portátil Lenovo E480  tiene el valor de {valorProducto5} con el IVA te queda en {totalPagar5}");
        break;

    case 6:
        int valorProducto6 = 1490000;
        double iva2 = (valorProducto6 * 19) / 100;
        double totalPagar6 = valorProducto6 + iva2;
        Console.WriteLine($"el Portátil Lenovo E480  tiene el valor de {valorProducto6} con el IVA te queda en {totalPagar6}");
        break;

    default: 
        Console.WriteLine("la opcion no es correcta, lo siento");
        break;
}
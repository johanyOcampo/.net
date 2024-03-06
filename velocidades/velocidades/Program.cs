//PREGUNTAR LOS DATOS
using System;

Console.Write("INGRESE LA VELOCIDAD EN KM: ");

//GUARDAR EL DATO
double velocidad = Convert.ToDouble(Console.ReadLine());
DateTime fecha = DateTime.Now;

//CONDICIONALES
if (velocidad > 30 && velocidad < 60)
{
    Console.WriteLine($"en esta fecha {fecha} ibas a {velocidad}km/h en Zonas Escolares cuando la permitidad es 30km/h");
}
else if (velocidad > 60 && velocidad <80)
{
    Console.WriteLine($"en esta fecha {fecha} ibas a {velocidad}km/h en Vías Urbanas  cuando la permitidad es 60km/h");
}
else if(velocidad > 80 && velocidad < 100)
{
    Console.WriteLine($"en esta fecha {fecha} ibas a {velocidad}km/h en Vías Rurales cuando la permitidad es 80km/h");
}
else if (velocidad > 100)
{
    Console.WriteLine($"en esta fecha {fecha} ibas a {velocidad}km/h en Rutas Nacionales cuando la permitidad es 100km/h");
}
else
{
    Console.WriteLine($"Error");
}
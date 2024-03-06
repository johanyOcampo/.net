Console.WriteLine("BIENVENIDO AL PROGRAMA DE SUBSIDIOS EL NANIS");
//PREGUNTAR AL USUARIO
Console.Write("Cual es su edad? ");
int edad = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el salario de la persona: ");
double salario = Convert.ToDouble(Console.ReadLine());

//CONDICIONALES
if (salario > 908526 || edad < 18)
{ 
    Console.WriteLine("lo siento, no puedes aplicar al subsidio");
}else if (salario <= 908526 && edad >=18 && edad <= 39)
{
    //OPERACIONES PARA EL SUBSIDIO
    double ValorSubsidio = (salario * 5) / 100;
    double TotalPagar = salario + ValorSubsidio;
    //IMPRIME LOS VALORES
    Console.WriteLine($"si tienes derecho al subsidio y su subsidio es: {ValorSubsidio} el total a pagar es {TotalPagar}");
}else if(salario <= 908526 && edad >= 40 && edad <= 64)
{
    double ValorSubsidio = (salario * 7) / 100;
    double TotalPagar = salario + ValorSubsidio;
    Console.WriteLine($"si tienes derecho al subsidio y su subsidio es: {ValorSubsidio} el total a pagar es {TotalPagar}");
}
else if (salario <= 908526 && edad > 64)
{
    double ValorSubsidio = (salario * 10) / 100;
    double TotalPagar = salario + ValorSubsidio;
    Console.WriteLine("Programa adulto mayor");
    Console.WriteLine($"Su salario es {salario} y su subsidio es: {ValorSubsidio} el total a pagar es {TotalPagar}");
}
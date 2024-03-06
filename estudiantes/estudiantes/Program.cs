//preguntar distancia
using System.Data;

Console.Write("a cuantos kilometros estas de la Universidad: ");
double distancia =Convert.ToDouble(Console.ReadLine());
//PREGUNTAR INGRESOS
Console.Write("cuales son sus ingresos familiares?: ");
double ingresos = Convert.ToDouble(Console.ReadLine());
//PREGUNTAR ESTRATO
Console.Write("cual es su estrato?: ");
int estrato = Convert.ToInt32(Console.ReadLine());


//DECLARAR VARIBABLES
DateTime fecha = DateTime.Now;

//CONDICIONALES
if (estrato <2  && ingresos < 600000 && distancia > 5)
{
    //CALCULO BECA
    double valorBeca = (1300000 * 44) / 100;
    Console.WriteLine($"el estudiante es apto el valor de la carrea es {valorBeca} y la fecha fue {fecha}");
}
else
{
    Console.WriteLine("el estudiante no es apto para la beca");
}
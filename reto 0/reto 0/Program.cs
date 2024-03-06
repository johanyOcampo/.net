Console.Write("INGRESE EL NOMBRE EMPLEADO: ");
String nombre = Console.ReadLine();

Console.Write("INGRESA EL SUELDO DEL EMPLEADO: ");
double Salario = Convert.ToDouble(Console.ReadLine());

Console.Write("INGRESA LA CANTIDAD DE HIJOS: ");
int hijos = Convert.ToInt32(Console.ReadLine());

if (hijos == 0 && Salario <= 1160000)
{
    double SalarioBono = Salario * 0;
    double TotalPagar = Salario + SalarioBono;
    Console.WriteLine($"El salario de {nombre} su bono es {SalarioBono} y su pago es: {TotalPagar}:");
}
else if (hijos >= 1 && hijos <=3 && Salario > 1160000 && Salario > 2320000)
{
    double SalarioBono = Salario * 0.10;
    double TotalPagar = Salario + SalarioBono;
    Console.WriteLine($"El salario de {nombre} su bono es {SalarioBono} y su pago es: {TotalPagar}:");
}
else if(hijos >= 3 && hijos <=5 && Salario <= 1160000)
{
    double SalarioBono = Salario * 0.25;
    double TotalPagar = Salario + SalarioBono;
    Console.WriteLine($"El salario de {nombre} su bono es {SalarioBono} y su pago es: {TotalPagar}:");
}
else
{
    Console.WriteLine($"El salario de {nombre} no tiene bono ");
}
{
    
}
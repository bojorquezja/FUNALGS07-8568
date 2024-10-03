// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double di = 0, pd = 0, ne, fa = 0, sb = 0, suf = 0, f1 = 0, f2 = 0, f3 = 0;
string no;
Console.WriteLine("Ingresa el numero de trabajadores");
ne = double.Parse(Console.ReadLine());
Console.WriteLine("_________________________________________________________________________________________");


for (int i = 0; i < ne; i++)
{
    Console.WriteLine("Ingrese  el  nombre  del trabajador");
    no = Console.ReadLine();
    Console.WriteLine("Ingrese la cantidad de dias trabajados");
    di = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el costo del dia trabajado");
    pd = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese los dias que falto el trabajador");
    fa = double.Parse(Console.ReadLine());
    sb = di * pd;
    f1 = pd * fa;
    suf = sb - f1;
    Console.WriteLine($"Nombre del empleado:{no}");
    Console.WriteLine($"Sueldo total: {suf}");
    Console.WriteLine($"Dias trabajados: {di}");
    Console.WriteLine($"Dias faltados: {fa}");
    Console.WriteLine($"El descuento: {f1}");
    if (2500 <= 3500)
    {
        f2++;
    }
    if (suf < 1000 || suf > 4000)
    {
        f3++;
    }

}
Console.WriteLine("_________________________________________________________________________________________");

Console.WriteLine($"El número de empleados que ganan entre 2500 y 3500: {f2++}");
Console.WriteLine($"El número de empleados que ganan menos de 1000 o más de 4000: {f3++}");

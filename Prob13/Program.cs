int Cantidad, DM, M1 = 0, M2 = 0;
double SueldoTotal = 0;
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Ingrese la cantidad de empleados = ");
Cantidad = int.Parse(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Ingrese la cantidad de días del mes = ");
DM = int.Parse(Console.ReadLine());
for (int i = 0; i < Cantidad; i++) //inicializacion
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Numero de empleados =  {i + 1}:");
    Console.Write("Nombre = ");
    string Name = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("Días que falto = ");
    int DiaF = int.Parse(Console.ReadLine());

    Console.Write("Salario mensual = ");
    double SM = double.Parse(Console.ReadLine());

    double SD = SM / DM;
    double SF = SM - (DiaF * SD);

    SueldoTotal += SF;

    if (SF >= 2500 && SF <= 3500)
    {
        M1++;
    }

    if (SF < 1000 || SF > 4000)
    {
        M2++;
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Sueldo final = " + SD);
    Console.WriteLine("\t******************");
    Console.WriteLine("Tu nombre es = " + Name);
    Console.WriteLine("\t******************");
}

Console.WriteLine("Monto total de sueldos = " + SueldoTotal);
Console.WriteLine("\t**************************************");
Console.WriteLine("Empleados que ganan entre 2500 y 3500 = " + M1);
Console.WriteLine("\t**************************************");
Console.WriteLine("Empleados que ganan menos de 1000 o mas de 4000: = " + M2);
Console.WriteLine("\t**************************************");
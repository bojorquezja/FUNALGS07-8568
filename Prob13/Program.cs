using System;

public class Program
{
	public static void Main()
	{
		int e, i,f,r1=0,r2=0;
		double sal,mt=0;
		string n;
		Console.WriteLine("Ingrese la cantidad de empleados");
		e = int.Parse(Console.ReadLine());

		for (i = 1; i <= e; i++)
		{
			Console.WriteLine($"\nIngrese nombre del empleado {i}");
			n = Console.ReadLine();
			Console.WriteLine("Ingrese su salario mensual");
			sal = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese las faltas del empleado");
			f = int.Parse(Console.ReadLine());
			Console.WriteLine($"Días trabajados por el empleado {n}: {30-f}");

			mt += sal;

			if (sal >= 2500 & sal <= 3500)
			{
				r1++;
			}
			else if (sal < 1000 || sal > 4000)
			{
				r2++;
			}



		}
		Console.WriteLine($"Monto total de todos los empleados: {mt}");
		Console.WriteLine($"Número de empleados que ganan de 2500 a 4000: {r1}");
		Console.WriteLine($"Número de empleados que ganan menos que 1000 o más que 4000: {r2}");


		Console.ReadKey();


	}
}
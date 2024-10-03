int n, diasMes, empleados1 = 0, empleados2 = 0;
double totalSueldos = 0;

Console.Write("Ingrese la cantidad de empleados: ");
n = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de días del mes: ");
diasMes = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) {
    Console.WriteLine($"\nEmpleado {i + 1}:");
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();

    Console.Write("Días que faltó: ");
    int diasFaltados = int.Parse(Console.ReadLine());

    Console.Write("Salario mensual: ");
    double salarioMensual = double.Parse(Console.ReadLine());

    double sueldoDiario = salarioMensual / diasMes;
    double sueldoFinal = salarioMensual - (diasFaltados * sueldoDiario);

    totalSueldos += sueldoFinal;

    if (sueldoFinal >= 2500 && sueldoFinal <= 3500) {
        empleados1++;
    }

    if (sueldoFinal < 1000 || sueldoFinal > 4000) {
        empleados2++;
    }

    Console.WriteLine($"Sueldo final de {nombre}: {sueldoFinal:C2}");
}

Console.WriteLine($"\nMonto total de sueldos: {totalSueldos:C2}");
Console.WriteLine($"Empleados que ganan entre 2500 y 3500: {empleados1}");
Console.WriteLine($"Empleados que ganan menos de 1000 o más de 4000: {empleados2}");
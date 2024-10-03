int nu, dias, faltas = 0, cont1 = 0, cont2 = 0;
double sueld = 0, pag_d, suma = 0, suel_t = 0, suel_t1 = 0, suel_t2 = 0, suma1 = 0, suma2 = 0;
string text;
Console.WriteLine("Ingresar numero de empleados: ");
nu = int.Parse(Console.ReadLine());
for (int i = 1; i <= nu; i++)
{
    Console.WriteLine("Ingresa el nombre del colaborador: ");
    text = Console.ReadLine();
    Console.WriteLine("Ingresar sueldo del colaborador: ");
    sueld = double.Parse(Console.ReadLine());

    if (sueld > 2500 && sueld < 3500)
    {
        Console.WriteLine("Ingresar numero de dias laborados: ");
        dias = int.Parse(Console.ReadLine());
        Console.WriteLine("Numero de faltas: ");
        faltas = int.Parse(Console.ReadLine());

        pag_d = sueld / 30;
        suel_t1 = sueld - (faltas * pag_d);
        suma1 = suma1 + suel_t1;
        cont1++;
    }
    else if (sueld < 1000 || sueld > 4000)
    {
        Console.WriteLine("Ingresar numero de dias laborados: ");
        dias = int.Parse(Console.ReadLine());
        Console.WriteLine("Numero de faltas: ");
        faltas = int.Parse(Console.ReadLine());

        pag_d = sueld / 30;
        suel_t2 = sueld - (faltas * pag_d);
        suma2 = suma2 + suel_t2;
        cont2++;
    }
    suma = suma1 + suma2;

}
Console.WriteLine("La suma total de sueldos de empleados es: " + suma);
Console.WriteLine("Numero de empleados que ganan entre 2500 y 3500: " + cont1);
Console.WriteLine("Numero de empleados que ganan menos de 1000 o más de 4000: " + cont2);

System.Console.Write("Введите первое значение: ");
double a = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите первое значение: ");
double b = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите третье значение: ");
double h = Convert.ToDouble(Console.ReadLine());

double V = a * b * h;
double S = 2 * (a + b) * h;

Console.WriteLine($"Обьем: {V}");
Console.WriteLine($"Площадь боковой поверхности: {S}");
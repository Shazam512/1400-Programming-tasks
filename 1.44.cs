System.Console.Write("Введите первое значение: ");
double a = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите первое значение: ");
double b = Convert.ToDouble(Console.ReadLine());

double p = 2 * (a + b);
double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

Console.WriteLine($"Периметор равен: {p}");
Console.WriteLine($"Диагональ: {d:F2}");
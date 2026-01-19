System.Console.Write("Введите первый катет: ");
double leg1 = double.Parse(Console.ReadLine());

System.Console.Write("Введите второй катет: ");
double leg2 = double.Parse(Console.ReadLine());

double h = Math.Sqrt(leg1 * leg1 + leg2 * leg2);
double p = leg1 + leg2 + h;

System.Console.WriteLine($"Периметр треугольника: {p}");
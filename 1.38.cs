System.Console.Write("Введите основания а: ");
double a = double.Parse(Console.ReadLine());

System.Console.Write("Введите основания b: ");
double b = double.Parse(Console.ReadLine());

System.Console.Write("Введите высоту h: ");
double h = double.Parse(Console.ReadLine());

double leg = Math.Abs(a - b) / 2;

double side = Math.Sqrt(h * h + leg * leg);

double p = a + b + 2 * side;

System.Console.WriteLine($"Периметр треугольника: {p}");
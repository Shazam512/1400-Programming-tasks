System.Console.Write("Введите значение A: ");
double a = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите значение B: ");
double b = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите значение H: ");
double h = Convert.ToDouble(Console.ReadLine());

double x = Math.Abs(a - b) / 2;
double side = Math.Sqrt(h * h + x * x);
double perimeter = a + b + 2 * side;
Console.WriteLine($"Периметр: {perimeter:F2}");
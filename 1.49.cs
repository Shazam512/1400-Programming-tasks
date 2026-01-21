System.Console.Write("Введите значение A: ");
double a = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите значение B: ");
double b = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите значение угол: ");
double angle = Convert.ToDouble(Console.ReadLine());

double x = Math.Abs(a - b) / 2;
double h = x * Math.Tan(angle * Math.PI / 180);
double area = (a + b) / 2 * h;
Console.WriteLine($"Площадь: {area:F2}");
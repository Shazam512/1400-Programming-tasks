System.Console.Write("Введите первое значение: ");
double x = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите первое значение: ");
double y = Convert.ToDouble(Console.ReadLine());

double z = (x + (2 + y) / Math.Pow(x, 2)) / (y + 1 / Math.Sqrt(Math.Pow(x, 2) + 10));
double q = 2.8 * Math.Sin(x) + Math.Abs(y);

System.Console.WriteLine($"z = {z:F2}, q = {q:F2}");
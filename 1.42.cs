System.Console.Write("Введите первое значение: ");
double e = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите первое значение: ");
double f = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите первое значение: ");
double g = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите первое значение: ");
double h = Convert.ToDouble(Console.ReadLine());

double a = (e + f / 2.0) / 3.0;
double b = Math.Abs(Math.Pow(h, 2) - g);
double c = Math.Sqrt(Math.Pow(g - h, 2) - 3 * Math.Sin(e));

System.Console.WriteLine($"a = {a:F2}, b = {b:F2}, c = {c:F2}");
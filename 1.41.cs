System.Console.Write("Введите первое значение: ");
double e = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите первое значение: ");
double f = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите первое значение: ");
double g = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите первое значение: ");
double h = Convert.ToDouble(Console.ReadLine());

double a = Math.Sqrt(Math.Pow(Math.Abs(e - 3 / f), 3) + g);
double b = Math.Sin(e) + Math.Pow(Math.Cos(h), 2);
double c = (33 * g) / (e * f - 3);

System.Console.WriteLine($"a = {a:F2}, b = {b:F2}, c = {c:F2}");
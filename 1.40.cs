System.Console.Write("Введите первое значение: ");
double a = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите первое значение: ");
double b = Convert.ToDouble(Console.ReadLine());

double x = (2 / (Math.Pow(a, 2) + 25) + b) / (Math.Sqrt(b) + (a + b) / 2);
double y = (Math.Abs(a) + 2 * Math.Sin(b)) / (5.5 * a);


System.Console.WriteLine($"x = {x:F2}, y = {y:F2}");

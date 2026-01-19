System.Console.Write("Введите первое значение: ");
double n1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите первое значение: ");
double n2 = Convert.ToDouble(Console.ReadLine());

double mod1 = Math.Abs(n1);
double mod2 = Math.Abs(n2);

double arith = (mod1 + mod2) / 2;
double geom = Math.Sqrt(mod1 * mod2);

Console.WriteLine($"Среднее арифметическое модулей: {arith}");
Console.WriteLine($"Среднее геометрическое модулей: {geom}");
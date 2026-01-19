System.Console.Write("Введите первый катет: ");
double a = double.Parse(Console.ReadLine());

System.Console.Write("Введите второй катет: ");
double b = double.Parse(Console.ReadLine());

double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

System.Console.WriteLine($"Гипотенуза равна: {c}");
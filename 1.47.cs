System.Console.Write("Введите значение X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите значение X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите значение Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите значение Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние: {d:F2}");
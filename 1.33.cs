System.Console.Write("Население: ");
long x = long.Parse(Console.ReadLine());

System.Console.Write("Площадь територий: ");
double y = Convert.ToDouble(Console.ReadLine());

double z = x / y;

System.Console.WriteLine($"Плотность населения составляет: {z:F1}");

Console.WriteLine("Введите координаты вершин (x1, y1, x2, y2, x3, y3):");
double x1 = double.Parse(Console.ReadLine()), y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine()), y2 = double.Parse(Console.ReadLine());
double x3 = double.Parse(Console.ReadLine()), y3 = double.Parse(Console.ReadLine());

// Стороны треугольника
double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

double perimeter = a + b + c;
double p = perimeter / 2;
double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

Console.WriteLine($"Периметр: {perimeter:F2}");
Console.WriteLine($"Площадь: {area:F2}");
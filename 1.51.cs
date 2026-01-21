Console.WriteLine("Введите координаты вершин (x1, y1, x2, y2, x3, y3, x4, y4):");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double x3 = double.Parse(Console.ReadLine());
double y3 = double.Parse(Console.ReadLine());
double x4 = double.Parse(Console.ReadLine());
double y4 = double.Parse(Console.ReadLine());

double s1 = Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0;

double s2 = Math.Abs(x1 * (y3 - y4) + x3 * (y4 - y1) + x4 * (y1 - y3)) / 2.0;

double totalArea = s1 + s2;
Console.Write($"Площадь четырехугольника: {totalArea}");
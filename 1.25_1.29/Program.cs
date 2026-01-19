// // 1.25 Преиметр квадрата
System.Console.Write("Стороная квадрата: ");
double side = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"Периметр = {4 * side}");

// // 1.26 Диаметр окружности
System.Console.Write("Радиус окружности: ");
double rad = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"Периметр = {2 * rad}");

// // 1.27 Расстояние до горизонта
const double R = 6350;
System.Console.Write("Введите растояние: ");
double h = Convert.ToDouble(Console.ReadLine());
double dist = Math.Sqrt(Math.Pow(R + h, 2) - Math.Pow(R, 2));
System.Console.WriteLine($"Растояние до горизонта = {dist:F2}");

// 1.28 Куб
System.Console.Write("Введите ребро куба: ");
double a = Convert.ToDouble(Console.ReadLine());
double V = Math.Pow(a, 3);
double S = 4 * Math.Pow(a, 2);
System.Console.WriteLine($"Обьем куба: {V}");
System.Console.Write($"Площать боковой поверхности: {S}");

// 1.29 Окружность и круг
System.Console.Write("Введите радиус окружности: ");
double r = Convert.ToDouble(Console.ReadLine());
double C = 2 * Math.PI * r;
double S = Math.PI * Math.Pow(r, 2);
System.Console.WriteLine($"Длина окружности: {C:F1}");
System.Console.WriteLine($"Площать круга: {S:F1}");

Console.Write("Скорость первого V1 (км/ч): ");
double v1 = double.Parse(Console.ReadLine());

Console.Write("Скорость второго V2 (км/ч): ");
double v2 = double.Parse(Console.ReadLine());

Console.Write("Начальный отрыв S (км): ");
double s = double.Parse(Console.ReadLine());

double time = 0.5;
double distance = s + (v1 - v2) * time;

Console.WriteLine($"Расстояние через 30 минут: {distance} км");
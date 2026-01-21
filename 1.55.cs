Console.Write("Скорость V1: ");
double v1 = double.Parse(Console.ReadLine());

Console.Write("Скорость V2: ");
double v2 = double.Parse(Console.ReadLine());

Console.Write("Расстояние S: ");
double s = double.Parse(Console.ReadLine());

double time = s / (v1 + v2);
Console.WriteLine($"Автомобили встретятся через {time} ч.");
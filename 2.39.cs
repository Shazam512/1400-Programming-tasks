Console.Write("Введите сколько часов: ");
int h = int.Parse(Console.ReadLine());

Console.Write("Введите сколько минут: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите сколько секунд: ");
int s = int.Parse(Console.ReadLine());

double angle = (h % 12) * 30 + m * 0.5 + s * (1.0 / 120.0);
Console.WriteLine($"2.39. Угол часовой стрелки: {angle}°");
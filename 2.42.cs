Console.Write("Введите часы: ");
int h = int.Parse(Console.ReadLine());

Console.Write("Введите минуты: ");
int m = int.Parse(Console.ReadLine());

double hA = (h % 12) * 30 + m * 0.5;
double mA = m * 6;

double diff = (mA - hA + 360) % 360;

double minMatch = (360 - diff) % 360 / 5.5;

double to90 = (90 - diff + 360) % 360 / 5.5;
double to270 = (270 - diff + 360) % 360 / 5.5;
double minPerp = Math.Min(to90, to270);

Console.WriteLine($"До совпадения: {(int)minMatch} мин. До перпендикуляра: {(int)minPerp} мин.");
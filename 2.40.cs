Console.Write("Введите угол: ");
double y = Convert.ToDouble(Console.ReadLine());

int hours = (int)(y / 30);

int minutes = (int)((y % 30) * 2);
Console.WriteLine($"2.40. Прошло {hours} ч. {minutes} мин.");
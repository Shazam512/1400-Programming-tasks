Console.Write("Введите число a1: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число a2: ");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());


int s1 = (a1 + b) % 10;
int s2 = (a2 + (a1 + b) / 10) % 10;

Console.WriteLine($"Цифры суммы: {s2}, {s1}");
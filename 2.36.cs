Console.Write("Введите число a1: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число a2: ");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число a2: ");
int a3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

int s1 = (a1 + b1) % 10;
int carry1 = (a1 + b1) / 10;

int s2 = (a2 + b2 + carry1) % 10;
int carry2 = (a2 + b2 + carry1) / 10;

int s3 = (a3 + carry2) % 10;

Console.WriteLine($"Цифры суммы: {s3}, {s2}, {s1}");
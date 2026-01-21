System.Console.Write("Введите первое число: ");
int width = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int side = Convert.ToInt32(Console.ReadLine());

int count = width / side;
Console.WriteLine($"Можно отрезать квадратов: {count}");

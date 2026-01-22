Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = (a % b) * (b % a) + 1;
Console.WriteLine($"Результат: {result}");
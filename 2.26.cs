System.Console.Write("Введите трехзначное число: ");
int res = Convert.ToInt32(Console.ReadLine());

int a = res % 10;
int b = res / 10;
int x = a * 100 + b;

Console.WriteLine($"2.26. Исходное число x: {x}");
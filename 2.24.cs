System.Console.Write("Введите трехзначное число: ");
int result = Convert.ToInt32(Console.ReadLine());

int c = result / 100;
int ab = result % 100;
int x = ab * 10 + c;

Console.WriteLine($"Исходное число x: {x}");
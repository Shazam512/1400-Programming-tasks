System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int h = number / 100;
int t = (number / 10) % 10;
int u = number % 10;

int reverse = u * 100 + t * 10 + h;
Console.WriteLine($"Справа налево: {reverse}");
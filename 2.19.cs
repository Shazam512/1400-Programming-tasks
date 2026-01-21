System.Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int d1 = n / 1000;
int d2 = (n / 100) % 10;
int d3 = (n / 10) % 10;
int d4 = n % 10;

int sum = d1 + d2 + d3 + d4;
int prod = d1 * d2 * d3 * d4;
Console.WriteLine($"Сумма: {sum}, Произведение: {prod}");
int n = 456;
int a = n / 100;
int c = (n / 10) % 10;
int b = n % 10;

int x = a * 100 + b * 10 + c;
Console.WriteLine($"Исходное число x: {x}");
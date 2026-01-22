Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

if (100 = n <= 999)
{
    int a = n / 100;
    int c = (n / 10) % 10;
    int b = n % 10;

    int x = a * 100 + b * 10 + c;
    Console.WriteLine($"Для n = {n}, исходное число x = {x}");
}
else
{
    System.Console.WriteLine("Ошибка! Введите число в промежутке 100<=n<=999");
}
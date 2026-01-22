Console.Write("Введите число n (1 <= n <= 999): ");
int n = Convert.ToInt32(Console.ReadLine());

if (1 = n <= 999)
{
    int c = n / 100;
    int b = (n / 10) % 10;
    int a = n % 10;

    int x = a * 100 + b * 10 + c;
    Console.WriteLine($"Для n = {n}, исходное число x = {x}");
}
else
{
    System.Console.WriteLine("Ошибка! Введите число в диапазоне 1 <= n <= 999");
}
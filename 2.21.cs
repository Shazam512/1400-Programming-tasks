System.Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 9)
{
    int units = n % 10;
    int tens = n / 10;
    System.Console.WriteLine($"Единиц в числе {units}, десятков {tens}");
}
else
{
    System.Console.WriteLine("Ошибка! Число должно быть больше 9.");
}
System.Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 999)
{
    int tens = n / 100;
    int hundreds = n / 1000;
    System.Console.WriteLine($"Полных сотен {hundreds}, полных тысяч {hundreds}");
}
else
{
    System.Console.WriteLine("Ошибка! Число должно быть больше 999.");
}
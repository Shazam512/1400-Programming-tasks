System.Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99)
{
    int tens = n / 10;
    int hundreds = n / 100;
    System.Console.WriteLine($"Полных десятков {tens}, полных сотен {hundreds}");
}
else
{
    System.Console.WriteLine("Ошибка! Число должно быть больше 99.");
}
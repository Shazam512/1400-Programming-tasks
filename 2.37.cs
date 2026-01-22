Console.Write("Введите число k: ");
int k = Convert.ToInt32(Console.ReadLine());

if (1 = k <= 180)
{
    int pairNumber = (k + 1) / 2;
    int number = 9 + pairNumber;
    int tens = number / 10;
    int units = number % 10;
    int digit = (tens * (k % 2)) + (units * ((k + 1) % 2));

    Console.WriteLine($"а) Номер пары: {pairNumber}");
    Console.WriteLine($"б) Двузначное число: {number}");
    Console.WriteLine($"в) k-я цифра: {digit}");
}
else
{
    System.Console.WriteLine("Ошибка! Введите число в диапазоне 1 <= k <= 180");
}
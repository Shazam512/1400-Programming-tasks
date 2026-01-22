Console.Write("Введите k: ");
int k = int.Parse(Console.ReadLine());

if (1 <= k <= 150)
{
    int position = (k + 2) / 3;

    int number = 100 + position;

    int digit1 = number / 100;
    int digit2 = (number / 10) % 10;
    int digit3 = number % 10;

    int isFirst = (k % 3 == 1) ? 1 : 0;
    int isSecond = (k % 3 == 2) ? 1 : 0;
    int isThird = (k % 3 == 0) ? 1 : 0;

    int resultDigit = (digit1 * isFirst) + (digit2 * isSecond) + (digit3 * isThird);

    Console.WriteLine($"Число, в которое входит цифра: {number}");
    Console.WriteLine($"k-я цифра: {resultDigit}");
}
else
{
    System.Console.WriteLine("Ошибка! Введите число в диапазоне 1 <= k <= 180");
}
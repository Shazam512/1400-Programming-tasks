Console.Write("Введите число n (10 <= n <= 999): ");
int n = int.Parse(Console.ReadLine());

int tensInN = (n / 10) % 10;

if (n >= 10 && n <= 999 && tensInN != 0)
{
    int firstDigitN = n / 100;
    int otherDigitsN = n % 100;

    int x = otherDigitsN * 10 + firstDigitN;
    Console.WriteLine($"Для n = {n}, исходное число x = {x}");
}
else
{
    Console.WriteLine("Число не соответствует условиям задачи.");
}
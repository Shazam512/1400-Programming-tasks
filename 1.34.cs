System.Console.Write("Введите коэфицент а: ");
double a = Convert.ToDouble(Console.ReadLine());

if (a == 0)
{
    System.Console.WriteLine("Ошибка! Значения [а] должно быть больше 0!");
}
else
{
    System.Console.Write("Введите коэфицент b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    double x = -b / a;
    System.Console.WriteLine($"Корень уровнения х = {x:F1}");
}


System.Console.Write("Введите массу: ");
double m = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите обьем: ");
double V = Convert.ToDouble(Console.ReadLine());
if (m > 0 && V > 0)
{
    double p = m / V;
    System.Console.WriteLine($"Плотность: {p:F1}");
}
else
{
    System.Console.WriteLine("Ошибка! Значение должны быть большее НУЛЯ!");
}


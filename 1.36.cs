System.Console.Write("Введите внешний радиус: ");
double R = double.Parse(Console.ReadLine());

System.Console.Write("Введите внутренний радиус: ");
double r = double.Parse(Console.ReadLine());

if (R > r)
{
    double s = Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2));
    System.Console.WriteLine($"Площадь кольца: {s:F2}");
}
else
{
    System.Console.WriteLine("Ошибка! Внешний радиус должен быть больше внитренного!");
}
System.Console.Write("Введите первое значение: ");
double a = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите первое значение: ");
double b = Convert.ToDouble(Console.ReadLine());

double sum = a + b;
double ras = a - b;
double pro = a * b;
double chas = a / b;

Console.WriteLine($"Сумма: {sum}");
Console.WriteLine($"Разность: {ras}");
Console.WriteLine($"Произведение: {pro}");
Console.WriteLine($"Частное: {chas:F2}");
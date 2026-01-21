Console.Write("Возраст Тани (X): ");
double x = double.Parse(Console.ReadLine());

Console.Write("Возраст Мити (Y): ");
double y = double.Parse(Console.ReadLine());

double aver = (x + y) / 2.0;
double diffX = Math.Abs(x - aver);
double diffY = Math.Abs(y - aver);

Console.WriteLine($"Средний возраст: {aver}");
Console.WriteLine($"Отклонение Тани: {diffX}, Отклонение Мити: {diffY}");
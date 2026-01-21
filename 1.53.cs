double monitor = 15000, caseUnit = 40000, keyboard = 1500, mouse = 800;
double onePc = monitor + caseUnit + keyboard + mouse;

Console.Write("Введите количество компьютеров (N): ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Стоимость 3 компьютеров: {onePc * 3}");
Console.WriteLine($"Стоимость {n} компьютеров: {onePc * n}");
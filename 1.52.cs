double priceCandy = 500, priceCookie = 300, priceApple = 150;

Console.Write("кг конфет: ");
double x = double.Parse(Console.ReadLine());

Console.Write("кг печенья: ");
double y = double.Parse(Console.ReadLine());

Console.Write("кг яблок: ");
double z = double.Parse(Console.ReadLine());

double total = (priceCandy * x) + (priceCookie * y) + (priceApple * z);
Console.WriteLine($"Общая стоимость: {total} руб.");
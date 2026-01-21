Console.Write("Введите температуру в градусах Цельсия: ");
double celsius = double.Parse(Console.ReadLine());

double fahrenheit = celsius * 1.8 + 32;
double kelvin = celsius + 273.15;

Console.WriteLine($"По Фаренгейту: {fahrenheit} °F");
Console.WriteLine($"По Кельвину: {kelvin} K");
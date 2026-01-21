System.Console.Write("Введите число: ");
double kg = Convert.ToDouble(Console.ReadLine());

double ton = kg / 100;
System.Console.WriteLine($"Полных тонн в {kg} кг: {ton}");
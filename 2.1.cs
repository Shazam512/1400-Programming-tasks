System.Console.Write("Введите число: ");
double cantimetr = Convert.ToDouble(Console.ReadLine());

double metr = cantimetr / 100;
System.Console.WriteLine($"Полных метров в {cantimetr} см: {metr}");
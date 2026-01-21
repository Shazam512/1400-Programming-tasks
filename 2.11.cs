System.Console.Write("Введите число: ");
int numder = Convert.ToInt32(Console.ReadLine());

int tens = numder / 10;
int units = numder % 10;

int swapp = units * 10 + tens;
System.Console.WriteLine($"Перестановка {number} в {swapp}");
System.Console.Write("Введите число: ");
int numder = Convert.ToInt32(Console.ReadLine());

int tens = numder / 10;
int units = numder % 10;
int sum = tens + units;
int prod = tens * units;

System.Console.WriteLine($"Число {number}. Десятки: {tens}, Единицы: {units}, Сумма: {sum}, Произв: {prod}");
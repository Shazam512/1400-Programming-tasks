System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int h = number / 100;
int t = (number / 10) % 10;
int u = number % 10;
int sum = h + t + u;
int prod = h * t * u;

System.Console.WriteLine($"Число {number}. Единицы: {u}, Десятки: {t}, Сумма: {sum}, Произв: {prod}");
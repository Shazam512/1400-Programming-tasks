System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int h = number / 100;
int t = (number / 10) % 10;
int u = number % 10;

int task = t * 100 + h * 10 + u;
Console.WriteLine($"Перестановка 1-й и 2-й цифр: {task}");
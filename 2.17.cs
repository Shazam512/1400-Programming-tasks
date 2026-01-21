System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int h = number / 100;
int t = (number / 10) % 10;
int u = number % 10;

int task = h * 100 + u * 10 + t;
Console.WriteLine($"Перестановка 2-й и 3-й цифр: {task}");
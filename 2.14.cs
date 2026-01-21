System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int h = number / 100;

int task = (number % 100) * 10 + h;
Console.WriteLine($"2.14: Первую в конец: {task}");
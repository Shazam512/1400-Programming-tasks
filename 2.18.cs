System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int h = number / 100;
int t = (number / 10) % 10;
int u = number % 10;

Console.WriteLine($"\nИсходные цифры: {h}, {t}, {u}");
Console.WriteLine("Шесть возможных чисел:");

int n1 = h * 100 + t * 10 + u;
Console.WriteLine($"1. {n1}");

int n2 = h * 100 + u * 10 + t;
Console.WriteLine($"2. {n2}");

int n3 = t * 100 + h * 10 + u;
Console.WriteLine($"3. {n3}");

int n4 = t * 100 + u * 10 + h;
Console.WriteLine($"4. {n4}");

int n5 = u * 100 + h * 10 + t;
Console.WriteLine($"5. {n5}");

int n6 = u * 100 + t * 10 + h;
Console.WriteLine($"6. {n6}");

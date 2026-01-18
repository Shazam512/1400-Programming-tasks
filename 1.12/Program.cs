System.Console.WriteLine("Введите t, v, x, y (через пробел): ");
string[] parts = Console.ReadLine().Split(' ');
int t = int.Parse(parts[0]);
int v = int.Parse(parts[1]);
int x = int.Parse(parts[2]);
int y = int.Parse(parts[3]);

System.Console.WriteLine("\na)");
System.Console.WriteLine("5 10");
System.Console.WriteLine("7 см");

System.Console.WriteLine("\nб)");
System.Console.WriteLine($"100 {t}");
System.Console.WriteLine($"1949 {v}");

System.Console.WriteLine("\nв)");
System.Console.WriteLine($"{x} 35");
System.Console.WriteLine($"{x} {y}");


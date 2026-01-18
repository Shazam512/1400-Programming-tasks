System.Console.WriteLine("Введите a, b, x, y (через пробел): ");
string[] parts = Console.ReadLine().Split(' ');
int a = int.Parse(parts[0]);
int b = int.Parse(parts[1]);
int x = int.Parse(parts[2]);
int y = int.Parse(parts[3]);

System.Console.WriteLine("\na)");
System.Console.WriteLine("2 кг");
System.Console.WriteLine("13 17");

System.Console.WriteLine("\nб)");
System.Console.WriteLine($"{a} 1");
System.Console.WriteLine($"19 {b}");

System.Console.WriteLine("\nв)");
System.Console.WriteLine($"{x} {y}");
System.Console.WriteLine($"5 {y}");


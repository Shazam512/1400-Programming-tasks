// а)
System.Console.Write("Введите а: ");
double a = Convert.ToDouble(Console.ReadLine());
double x = Math.Sqrt((2 * a + Math.Sin(Math.Abs(3 * a))) / 3.56);
System.Console.WriteLine($"x = {x}");

// б)
System.Console.Write("Введите x: ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y = Math.Sin((3.2 + Math.Sqrt(1 + x2)) / Math.Abs(5 * x2));
System.Console.WriteLine($"y = {y}");
System.Console.Write("Введите а: ");
double a = Convert.ToDouble(Console.ReadLine());
double y = (Math.Pow(a, 2) + 10) / Math.Sqrt(Math.Pow(a, 2) + 1);
System.Console.WriteLine($"y = {y}");
System.Console.Write("Число 1: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Число 2: ");
int b = int.Parse(Console.ReadLine());

// a)
double arif = (a + b) / 2;
System.Console.WriteLine($"Среднее арифмитическое: {arif}");

// б)
double geom = 0;
if (a * b >= 0)
{
    geom = Math.Sqrt(a * b);
}
System.Console.WriteLine($"Среднее гаометрическое: {geom:F2}");
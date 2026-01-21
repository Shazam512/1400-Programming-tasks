System.Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int d1 = n / 1000;
int d2 = (n / 100) % 10;
int d3 = (n / 10) % 10;
int d4 = n % 10;

int reverse = d4 * 1000 + d3 * 100 + d2 * 10 + d1;

int pairs = (d2 * 1000 + d1 * 100) + (d4 * 10 + d3);

int middle = d1 * 1000 + d3 * 100 + d2 * 10 + d4;

int taskG1 = (d3 * 1000 + d4 * 100) + (d1 * 10 + d2);

int taskG2 = (n % 100) * 100 + (n / 100);
Console.Write("Введите угол: ");
double yR = Convert.ToDouble(Console.ReadLine());

double yD = yR * (180.0 / Math.PI);

int hours = (int)(yD / 30);
double minutesExact = (yD % 30) * 2;
int fullMinutes = (int)minutesExact;

double minuteDeg = (minutesExact % 60) * 6;
double minuteRad = minuteDeg * (Math.PI / 180.0);

Console.WriteLine($"2.41. Часов: {hours}, Минут: {fullMinutes}, Угол минутной (рад): {minuteRad}");
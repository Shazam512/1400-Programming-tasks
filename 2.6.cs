System.Console.Write("Введите число: ");
int seconds = Convert.ToInt32(Console.ReadLine());

int hours = seconds / 3600;
Console.WriteLine($"Прошло полных часов: {hours}");

int fullMinutesFromHour = (seconds % 3600) / 60;
Console.WriteLine($"Минут с начала часа: {fullMinutesFromHour}");

int fullSecondsFromMinute = seconds % 60;
Console.WriteLine($"Секунд с начала минуты: {fullSecondsFromMinute}");

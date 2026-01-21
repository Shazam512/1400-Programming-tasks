System.Console.Write("Введите день недели: ");
int k = Convert.ToInt32(Console.ReadLine());

int dayA = k % 7;
System.Console.WriteLine($"а) Если 1 янв Пн, то {k}-й день это: {dayA}");

int dayB = (k + 1) % 7;
System.Console.WriteLine($"б) Если 1 янв Вт, то {k}-й день это: {dayB}");

System.Console.Write("Введите день недели: ");
int d = Convert.ToInt32(Console.ReadLine());

int dayV = (k + d - 2) % 7 + 1;
System.Console.WriteLine($"в) Если 1 янв d={d}, то {k}-й день это: {dayV}");


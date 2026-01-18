double x1 = 3, x2 = 4, x3 = 5, v0 = 10, t = 2, a = 9.8, m = 5, v = 10, g = 9.8, h = 2, R1 = 10, R2 = 20, alpha = Math.PI / 4, R = 5, b = 10, c = 2, gamma = 6.67, m1 = 100, m2 = 200, r = 50, I = 2, d = 4, x = 10;
double result;

// а) Корень из суммы квадратов
result = Math.Sqrt(x1 * x1 + x2 * x2);
Console.WriteLine($"а) {result}");

// б) Сумма попарных произведений
result = x1 * x2 + x1 * x3 + x2 * x3;
Console.WriteLine($"б) {result}");

// в) Путь при равноускоренном движении
result = v0 * t + (a * t * t) / 2.0;
Console.WriteLine($"в) {result}");

// г) Полная механическая энергия
result = (m * v * v) / 2.0 + m * g * h;
Console.WriteLine($"г) {result}");

// д) Сумма проводимостей (1/R)
result = 1.0 / R1 + 1.0 / R2;
Console.WriteLine($"д) {result}");

// е) Проекция силы тяжести (cos принимает радианы!)
result = m * g * Math.Cos(alpha);
Console.WriteLine($"е) {result}");

// ж) Длина окружности
result = 2 * Math.PI * R;
Console.WriteLine($"ж) {result}");

// з) Дискриминант (b^2 - 4ac)
result = b * b - 4 * a * c;
Console.WriteLine($"з) {result}");

// и) Закон всемирного тяготения
result = gamma * (m1 * m2) / (r * r);
Console.WriteLine($"и) {result}");

// к) Мощность тока (I^2 * R)
result = I * I * R;
Console.WriteLine($"к) {result}");

// л) Произведение сторон на синус угла (ab sin c)
result = a * b * Math.Sin(c);
Console.WriteLine($"л) {result}");

// м) Теорема косинусов (сторона треугольника)
result = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(c));
Console.WriteLine($"м) {result}");

// н) (ad + bc) / ad
result = (a * d + b * c) / (a * d);
Console.WriteLine($"н) {result}");

// о) Корень из (1 - sin^2 x)
result = Math.Sqrt(1 - Math.Pow(Math.Sin(x), 2));
Console.WriteLine($"о) {result}");

// п) 1 / корень квадратного трехчлена
result = 1.0 / Math.Sqrt(a * x * x + b * x + c);
Console.WriteLine($"п) {result}");

// р) Дробь с корнями
result = (Math.Sqrt(x + 1) + Math.Sqrt(x - 1)) / (2 * Math.Sqrt(x));
Console.WriteLine($"р) {result}");

// с) Сумма модулей (|x| + |x+1|)
result = Math.Abs(x) + Math.Abs(x + 1);
Console.WriteLine($"с) {result}");

// т) Модуль выражения с вложенным модулем (|1 - |x||)
result = Math.Abs(1 - Math.Abs(x));
Console.WriteLine($"т) {result}");
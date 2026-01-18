// а) -1 / x^2
double resA = -1 / Math.Pow(x, 2);

// б) a / (bc)
double resB = a / (b * c);

// в) (a / b) * c
double resV = (a / b) * c;

// г) (a + b) / 2
double resG = (a + b) / 2.0;

// д) 5.45 * ((a + 2b) / (2 - a))
double resD = 5.45 * (a + 2 * b) / (2 - a);

// е) (-b + sqrt(b^2 - 4ac)) / 2a
double resE = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

// ж) (-b + 1/a) / (2/c)
double resJ = (-b + 1.0 / a) / (2.0 / c);

// з) 1 / (1 + (a + b) / 2)
double resZ = 1 / (1 + (a + b) / 2.0);

// и) Сложная многоэтажная дробь
double resI = 1 / (1 + 1 / (2 + 1 / (2 + 3.0 / 5.0)));

// к) 2^(m^n)
double resK = Math.Pow(2, Math.Pow(m, n));
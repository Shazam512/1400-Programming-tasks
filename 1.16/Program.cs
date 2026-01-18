double a = 10, b = 5, c = 2, d = 1, x = 0.5, R = 1;

// а) a/b/c
double resA = a / b / c;
Console.WriteLine($"а) {resA}");

// б) a*b/c
double resB = a * b / c;
Console.WriteLine($"б) {resB}");

// в) a/b*c
double resV = a / b * c;
Console.WriteLine($"в) {resV}");

// г) a+b/c
double resG = a + b / c;
Console.WriteLine($"г) {resG}");

// д) (a+b)/c
double resD = (a + b) / c;
Console.WriteLine($"д) {resD}");

// е) a+b/b+c=>a+1+c
double resE = a + b / b + c;
Console.WriteLine($"е) {resE}");

// ж) (a+b)/(b+c)
double resJ = (a + b) / (b + c);
Console.WriteLine($"ж) {resJ}");

// з) a/sin(b)
double resZ = a / Math.Sin(b);
Console.WriteLine($"з) {resZ}");

// и) 1/2*a*b*sin(x)
double resI = 0.5 * a * b * Math.Sin(x);
Console.WriteLine($"и) {resI}");

// к) 2*b*c*cos(a/2)/(b+c)
double resK = 2 * b * c * Math.Cos(a / 2.0) / (b + c);
Console.WriteLine($"к) {resK}");

// л) 4*R*sin(a/2)*sin(b/2)*sin(c/2)
double resL = 4 * R * Math.Sin(a / 2.0) * Math.Sin(b / 2.0) * Math.Sin(c / 2.0);
Console.WriteLine($"л) {resL}");

// м) (a*x+b)/(c*x+d)
double resM = (a * x + b) / (c * x + d);
Console.WriteLine($"м) {resM}");

// н) 2*sin((a+b)/2)*cos((a-b)/2)
double resN = 2 * Math.Sin((a + b) / 2.0) * Math.Cos((a - b) / 2.0);
Console.WriteLine($"н) {resN}");

// о) abs(2*sin(-3*abs(x/2)))
double resO = Math.Abs(2 * Math.Sin(-3 * Math.Abs(x / 2.0)));
Console.WriteLine($"о) {resO}");
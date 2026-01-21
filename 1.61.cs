double a = 2;
double res;
double a2, a3, a4, a5, a6, a7, a8, a10, a12, a13, a14, a15, a20, a21, a28, a32, a64;

// а)
a2 = a * a;
res = a2 * a2;

// б)
a2 = a * a;
a3 = a2 * a;
res = a3 * a3;

// в)
a2 = a * a;
a3 = a2 * a;
a4 = a2 * a2;
res = a4 * a3;

// г)
a2 = a * a;
a4 = a2 * a2;
res = a4 * a4;

// д)
a2 = a * a;
a4 = a2 * a2;
a8 = a4 * a4;
res = a8 * a;

// е)
a2 = a * a;
a4 = a2 * a2;
a8 = a4 * a4;
res = a8 * a2;

// ж)
a2 = a * a;
a4 = a2 * a2;
a8 = a4 * a4;
a12 = a8 * a4;
res = a12 * a;

// з)
a2 = a * a;
a3 = a2 * a;
a6 = a3 * a3;
a12 = a6 * a6;
res = a12 * a3;

// и)
a2 = a * a;
a4 = a2 * a2;
a5 = a4 * a;
a10 = a5 * a5;
a20 = a10 * a10;
res = a20 * a;

// к)
a2 = a * a;
a4 = a2 * a2;
a7 = a4 * (a2 * a);
a14 = a7 * a7;
res = a14 * a14;

// л)
a2 = a * a;
a4 = a2 * a2;
a8 = a4 * a4;
a16 = a8 * a8;
a32 = a16 * a16;
res = a32 * a32;

Console.WriteLine($"a^64 = {a64}");
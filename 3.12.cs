// 3.12
// a)
int xA = 1;
int yA = -1;
bool resA = Math.Pow(xA, 2) + Math.Pow(yA, 2) <= 0;
System.Console.WriteLine(resA);

// б)
int xB = 2;
int yB = -2;
bool resB = (xB >= 2) || (Math.Pow(yB, 2) != 4);
System.Console.WriteLine(resB);

// в)
int xC = 2;
int yC = 2;
bool resC = (xC >= 0) && (Math.Pow(yB, 2) > 4);
System.Console.WriteLine(resC);

// г)
int xD = 1;
int yD = 2;
bool resD = (xD * yD != 4) && (yD > xD);
System.Console.WriteLine(resD);

// д)
int xE = 2;
int yE = 1;
bool resE = (xE * yE != 0) || (yE < xE);
System.Console.WriteLine(resE);

// е)
int xF = 1;
int yF = 2;
bool resF = (!(xF * yF < 1)) && (yF > xF);
System.Console.WriteLine(resF);

// ж)
int xG = 2;
int yG = 1;
bool resG = (!(xG * yG < 0)) || (yG > xG);
System.Console.WriteLine(resG);
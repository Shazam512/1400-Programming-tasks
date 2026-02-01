// 3.11
// a)
int xA = 1;
int yA = -1;
bool resA = Math.Pow(xA, 2) + Math.Pow(yA, 2) <= 4;
System.Console.WriteLine(resA);

// б)
int xB = 1;
int yB = 2;
bool resB = (xB >= 0) || (Math.Pow(yB, 2) != 4);
System.Console.WriteLine(resB);

// в)
int xC = 1;
int yC = 2;
bool resC = (xC >= 0) && (Math.Pow(yB, 2) != 4);
System.Console.WriteLine(resC);

// г)
int xD = 2;
int yD = 1;
bool resD = (xD * yD != 0) && (yD > xD);
System.Console.WriteLine(resD);

// д)
int xE = 2;
int yE = 1;
bool resE = (xE * yE != 0) || (yE < xE);
System.Console.WriteLine(resE);

// е)
int xF = 2;
int yF = 1;
bool resF = (!(xF * yF < 0)) && (yF > xF);
System.Console.WriteLine(resF);

// ж)
int xG = 1;
int yG = 2;
bool resG = (!(xG * yG < 0)) || (yG > xG);
System.Console.WriteLine(resG);
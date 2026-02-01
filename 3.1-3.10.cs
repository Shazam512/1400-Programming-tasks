// 3.1
bool A = true;
bool B = false;
bool C = false;

bool result1 = A || B;
System.Console.WriteLine(result1);

bool result2 = A && B;
System.Console.WriteLine(result2);

bool result3 = B || C;
System.Console.WriteLine(result3);


// 3.2
bool Y = true;
bool X = false;
bool Z = false;

bool resultA = X || Z;
System.Console.WriteLine(resultA);

bool resultB = Y && X;
System.Console.WriteLine(resultB);

bool resultC = X && Z;
System.Console.WriteLine(resultC);


// 3.3
bool P = true;
bool Q = false;
bool R = false;

bool resultD = !P && Q;
System.Console.WriteLine(resultD);

bool resultE = P || !Q;
System.Console.WriteLine(resultE);

bool resultF = Q && R || P;
System.Console.WriteLine(resultF);


// 3.4
bool M = false;
bool N = false;
bool O = true;

bool resultG = !M && N;
System.Console.WriteLine(resultG);

bool resultH = M && !O;
System.Console.WriteLine(resultH);

bool resultI = N || O && M;
System.Console.WriteLine(resultI);


// 3.5
bool D = true;
bool E = false;
bool F = false;

bool resultJ = D || E && !F;
System.Console.WriteLine(resultJ);
bool resultK = !D && !E;
System.Console.WriteLine(resultK);
bool resultL = !(D && F) || E;
System.Console.WriteLine(resultL);
bool resultM = D && !E || F;
System.Console.WriteLine(resultM);
bool resultN = D && (!E || F);
System.Console.WriteLine(resultN);
bool resultO = D || (!(E && F));


// 3.6
bool S = false;
bool T = false;
bool U = true;

bool resultP = S || T && !U;
System.Console.WriteLine(resultP);
bool resultQ = !S && !T;
System.Console.WriteLine(resultQ);
bool resultR = !(S && T) || U;
System.Console.WriteLine(resultR);
bool resultS = S && !T || U;
System.Console.WriteLine(resultS);
bool resultT = S && (!T || U);
System.Console.WriteLine(resultT);
bool resultU = S || (!(T && U));
System.Console.WriteLine(resultU);


// 3.7
bool V = true;
bool W = false;
bool X = false;

bool resultV = V || !(V && W) || X;
System.Console.WriteLine(resultV);
bool resultW = !V || V && (W || X);
System.Console.WriteLine(resultW);
bool resultX = (V || W && !X) && X;
System.Console.WriteLine(resultX);


// 3.8
bool J = false;
bool K = true;
bool L = false;

bool resultY = J && !(L || K) || !L;
System.Console.WriteLine(resultY);
bool resultZ = !J || J && (K && L);
System.Console.WriteLine(resultZ);
bool resultAA = (J || K && !L) && L;
System.Console.WriteLine(resultAA);


// 3.9
bool F = true;
bool G = false;
bool H = false;

bool result9 = !F || !G || !H;
System.Console.WriteLine(result9);
bool result10 = (!F || !G) && (F || G);
System.Console.WriteLine(result10);
bool result1 = F && G || F && H || !H;
System.Console.WriteLine(result1);


// 3.10
bool A = false;
bool B = false;
bool C = true;

bool result11 = (!A || !B) && !C;
System.Console.WriteLine(result11);
bool result12 = (!A || !B) && (A || B);
System.Console.WriteLine(result12);
bool result13 = A || B && A || C && !C;
System.Console.WriteLine(result13);
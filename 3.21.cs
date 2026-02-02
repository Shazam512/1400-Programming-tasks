System.Console.WriteLine("A B C | a | b | c");

for (int ai = 0; ai <= 1; ai++)
{
    for (int bi = 0; bi <= 1; bi++)
    {
        for (int ci = 0; ci <= 1; ci++)
        {
            bool A = ai == 1;
            bool B = bi == 1;
            bool C = ci == 1;

            bool a = !(A || !B && C);
            bool b = A && !(B || !C);
            bool c = !(!A || B && C);

            System.Console.WriteLine($"{ai} {bi} {ci} | {BoolToInt(a)} | {BoolToInt(b)} | {BoolToInt(c)}");
        }
    }
}

static int BoolToInt(bool v) => v ? 1 : 0;
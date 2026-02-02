System.Console.WriteLine("A B | a | b | c");

for (int ai = 0; ai <= 1; ai++)
{
    for (int bi = 0; bi <= 1; bi++)
    {
        bool A = ai == 1;
        bool B = bi == 1;

        bool a = !(!A && !B) || A;
        bool b = !(!A || !B) || B;
        bool c = !(!A || !B) && B;

        System.Console.WriteLine($"{ai} {bi} | {BoolToInt(a)} | {BoolToInt(b)} | {BoolToInt(c)}");
    }
}

static int BoolToInt(bool v) => v ? 1 : 0;
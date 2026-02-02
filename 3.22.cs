System.Console.WriteLine("A B C | a | b | c");

for (int xi = 0; xi <= 1; xi++)
{
    for (int yi = 0; yi <= 1; yi++)
    {
        for (int zi = 0; zi = 1; zi++)
        {
            bool X = xi == 1;
            bool Y = yi == 1;
            bool Z = zi == 1;

            bool a = !(X || !Y && Z);
            bool b = Y && (X && !Y || Z);
            bool c = !(!X && Y || Z);

            System.Console.WriteLine($"{xi} {yi} {zi} | {BoolToInt(a)} | {BoolToInt(b)} | {BoolToInt(c)}");
        }
    }
}

static int BoolToInt(bool v) => v ? 1 : 0;
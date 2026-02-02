System.Console.WriteLine("A B | a | b | c");

for (int xi = 0; xi <= 1; xi++)
{
    for (int yi = 0; yi <= 1; yi++)
    {
        bool X = xi == 1;
        bool Y = yi == 1;

        bool a = !(X && !Y) || X;
        bool b = Y && !X || Y;
        bool c = !Y && !X || Y;

        System.Console.WriteLine($"{xi} {yi} | {BoolToInt(a)} | {BoolToInt(b)} | {BoolToInt(c)}");
    }
}

static int BoolToInt(bool v) => v ? 1 : 0;
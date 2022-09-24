Console.Clear();

//Console.SetCursorPosition(10, 4);

//Console.WriteLine("+");


int xa = 1, ya = 1, 
    xb = 30, yb = 30,
    xc = 60, yc = 1,
    xd = 7, yd = 5;

Console.SetCursorPosition(xa, ya);
Console.WriteLine(".");

Console.SetCursorPosition(xb, yb);
Console.WriteLine(".");

Console.SetCursorPosition(xc, yc);
Console.WriteLine(".");

Console.SetCursorPosition(xd, yd);
Console.WriteLine(".");

int x = xa, y = yc;

int count = 0;

while(count<100000)
{
    int what = new Random().Next(0, 3); // [0,3) 0 1 2 3
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    if (what == 3)
    {
        x = (x + xd) / 3;
        y = (y + yd) / 3;
    }

    Console.SetCursorPosition(x, y);
    Console. WriteLine("+");
    count++;

}





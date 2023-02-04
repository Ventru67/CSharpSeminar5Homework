// Написать программу масштабирования фигуры
Console.Clear();

int xa = 0, ya = 0,
    xb = 2, yb = 0,
    xc = 2, yc = 2,
    xd = 0, yd = 2;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

Console.SetCursorPosition(xd, yd);
Console.WriteLine("*");

Console.Write("Введите коэффициент масштабирования : ");
int number = int.Parse(Console.ReadLine() ?? "0");

int xa1 = xa * number, ya1 = ya * number,
    xb1 = xb * number, yb1 = yb * number,
    xc1 = xc * number, yc1 = yc * number,
    xd1 = xd * number, yd1 = yd * number;

Console.Clear();

Console.SetCursorPosition(xa1, ya1);
Console.WriteLine("*");

Console.SetCursorPosition(xb1, yb1);
Console.WriteLine("*");

Console.SetCursorPosition(xc1, yc1);
Console.WriteLine("*");

Console.SetCursorPosition(xd1, yd1);
Console.WriteLine("*");

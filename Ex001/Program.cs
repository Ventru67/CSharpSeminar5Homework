// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Первый отрезок: y = k1 * x + b1");
Console.WriteLine("Второй отрезок: y = k2 * x + b2");
Console.Write("Введите k1= ");
int k1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите b1 = ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите k2 = ");
int k2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите b2 = ");
int b2 = int.Parse(Console.ReadLine() ?? "0");

if (k1 != k2)
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k2 * x + b2;
    Console.WriteLine($"Точка пересечения : {(x, y)}");
}
else
{
    Console.WriteLine($"Прямые параллельны");
}

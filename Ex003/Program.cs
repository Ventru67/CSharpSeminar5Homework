// Написать программу копирования массива
void FillArray(int[] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        matr[i] = new Random().Next(1, 10);
    }
    Console.WriteLine(String.Join(", ", matr));
}
void CopyArray(int[] matr)
{
    Console.WriteLine("Копия: ");
    int[] copy = new int[matr.Length];
    for (int i = 0; i < matr.Length; i++)
    {
        copy[i] = matr[i];
    }
    Console.WriteLine(String.Join(", ", copy));
}

Console.WriteLine("Введите длинну массива: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[number];

FillArray(array);
CopyArray(array);

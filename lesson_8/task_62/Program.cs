// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralFillingArray(int line, int row)
{
    int[,] spiral = new int[line, row];
    int sizeL = spiral.GetLength(0) - 1;
    int sizeR = spiral.GetLength(1) - 1;
    int num = 1;
    for (int count = 0; count <= sizeL; count++)
    {
        for (int i = count; i <= sizeL - count; i++)
        {
            spiral[count, i] = num;
            num++;
        }
        num--;
        for (int j = count; j <= sizeR - count; j++)
        {
            spiral[j, sizeL - count] = num;
            num++;
        }
        num--;
        for (int k = sizeL - count; k >= count; k--)
        {
            spiral[sizeL - count, k] = num;
            num++;
        }
        num--;
        for (int l = sizeL - count; l >= 1 + count; l--)
        {
            spiral[l, count] = num;
            num++;
        }
    }
    return spiral;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Enter count of rows: ");
int rowsArray = int.Parse(Console.ReadLine());
Console.Write("Enter count of lines: ");
int linesArray = int.Parse(Console.ReadLine());
Console.WriteLine("********************************************");
Console.WriteLine();

int[,] newArrayMatrix = SpiralFillingArray(linesArray, rowsArray);
PrintArray(newArrayMatrix);
Console.WriteLine();
Console.WriteLine("********************************************");

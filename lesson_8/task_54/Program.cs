// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] BiArray(int beginArray, int endArray, int row, int line)
{
    int[,] newTwoRealArray = new int[row, line];
    for (int i = 0; i < newTwoRealArray.GetLength(0); i++)
    {
        for (int j = 0; j < newTwoRealArray.GetLength(1); j++)
        {
            newTwoRealArray[i, j] = new Random().Next(beginArray, endArray);
        }
    }
    return newTwoRealArray;
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

int[,] SortBiArray(int[,] biArray)
{
    for (int i = 0; i < biArray.GetLength(0); i++)
    {
        for (int j = 0; j < biArray.GetLength(1) - 1; j++)
        {
            int maxPos = j;
            for (int k = j + 1; k < biArray.GetLength(1); k++)
            {
                if (biArray[i, k] > biArray[i, maxPos]) maxPos = k;
            }
            int maxTempInArray = biArray[i, j];
            biArray[i, j] = biArray[i, maxPos];
            biArray[i, maxPos] = maxTempInArray;
        }
    }
    return biArray;
}

Console.Write("Enter count of rows: ");
int rowsArray = int.Parse(Console.ReadLine());
Console.Write("Enter count of lines: ");
int linesArray = int.Parse(Console.ReadLine());
Console.Write("Enter beginning of the segment: ");
int beginSegment = int.Parse(Console.ReadLine());
Console.Write("Enter end of the segment: ");
int endSegment = int.Parse(Console.ReadLine());
Console.WriteLine("********************************************");

int[,] newArrayMatrix = BiArray(beginSegment, endSegment, linesArray, rowsArray);
PrintArray(newArrayMatrix);
Console.WriteLine("********************************************");
int[,] newArrayMatrix1 = SortBiArray(newArrayMatrix);
PrintArray(newArrayMatrix1);







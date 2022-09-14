// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 

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

void AverageRowsArray(int[,] biArray)
{
    int count = 0;
    for (int j = 0; j < biArray.GetLength(1); j++)
    {
        double tempAve = 0;
        double sumRows = 0;
        for (int i = 0; i < biArray.GetLength(0); i++)
        {
            sumRows += biArray[i, j];
        }
        tempAve = sumRows / biArray.GetLength(0);
        count++;
        Console.WriteLine($"Average row {count} = {tempAve:f};");
    }
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
AverageRowsArray(newArrayMatrix);




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void SortMinSumLinesBiArray(int[,] biArray)
{

    int sumLines = 0;
    int count = 0;
    int sumFirstLines = 0;
    for (int k = 0; k < biArray.GetLength(1); k++)
    {
        sumFirstLines += biArray[0, k];
    }
    for (int i = 0; i < biArray.GetLength(0); i++)
    {
        for (int j = 0; j < biArray.GetLength(1); j++)
        {
            sumLines += biArray[i, j];
        }
        Console.WriteLine($"Sum lines {i+1} = {sumLines} ");
        if (sumFirstLines > sumLines)
        {
            sumFirstLines = sumLines;
            count = i;
        }
        sumLines = 0;
    }
    Console.WriteLine("********************************************");
    Console.WriteLine($"Count lines with min sum elements = {count + 1}");
}


Console.Write("Enter count of rows: ");
int rowsArray = int.Parse(Console.ReadLine());
Console.Write("Enter count of lines != rows: ");
int linesArray = int.Parse(Console.ReadLine());
if (rowsArray == linesArray)
{
    Console.WriteLine("Введите значения не равные друг другу");
    return;
}
Console.Write("Enter beginning of the segment: ");
int beginSegment = int.Parse(Console.ReadLine());
Console.Write("Enter end of the segment: ");
int endSegment = int.Parse(Console.ReadLine());
Console.WriteLine("********************************************");

int[,] newArrayMatrix = BiArray(beginSegment, endSegment, linesArray, rowsArray);
PrintArray(newArrayMatrix);
Console.WriteLine("********************************************");

SortMinSumLinesBiArray(newArrayMatrix);





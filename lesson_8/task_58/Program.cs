// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplicationMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] arrayMulti = new int[firstArray.GetLength(0), firstArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < secondArray.GetLength(0); k++)
            {
                arrayMulti[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return arrayMulti;
}

Console.Write("Enter count of rows: ");
int rowsArray = int.Parse(Console.ReadLine());
Console.Write("Enter count of lines = rows: ");
int linesArray = int.Parse(Console.ReadLine());
if (rowsArray != linesArray)
{
    Console.WriteLine("Enter correct value!");
    return;
}
Console.Write("Enter beginning of the segment: ");
int beginSegment = int.Parse(Console.ReadLine());
Console.Write("Enter end of the segment: ");
int endSegment = int.Parse(Console.ReadLine());
Console.WriteLine("********************************************");

int[,] firstArrayMatrix = BiArray(beginSegment, endSegment, linesArray, rowsArray);
int[,] secondArrayMatrix = BiArray(beginSegment, endSegment, linesArray, rowsArray);
Console.WriteLine("First matrix: ");
PrintArray(firstArrayMatrix);
Console.WriteLine("********************************************");
Console.WriteLine("Second matrix: ");
PrintArray(secondArrayMatrix);
Console.WriteLine("********************************************");
Console.WriteLine("Multiplication first matrix on second matrix: ");
int[,] multiplicationArrayMatrix = MultiplicationMatrix(firstArrayMatrix, secondArrayMatrix);
PrintArray(multiplicationArrayMatrix);



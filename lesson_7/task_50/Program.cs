// Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] TwoIntArray(int beginArray, int endArray, int row, int line)  
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

void PrintArray1(int[,] matr)
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

void SearchPosition(int[,] array, int numbers)
{
    int count = 0;
    int countPosition = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == numbers)
            {
        
                Console.WriteLine($"Position {countPosition} found element have to index ({i}, {j});");
                countPosition++;
                count++;
            }
        }

    }
    if (count > 0) return;
    else Console.WriteLine("Element not in array");
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

int[,] newArrayMatrix = TwoIntArray(beginSegment, endSegment, rowsArray, linesArray);
PrintArray1(newArrayMatrix);

Console.WriteLine("********************************************");
Console.Write("Enter a number to search for: ");
int searchNumber = int.Parse(Console.ReadLine());

Console.WriteLine("********************************************");
SearchPosition(newArrayMatrix, searchNumber);


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] TwoRealArray(int row, int line, int arg1)
{
    double[,] newTwoRealArray = new double[row, line];
    for (int i = 0; i < newTwoRealArray.GetLength(0); i++)
    {
        for (int j = 0; j < newTwoRealArray.GetLength(1); j++)
        {
            newTwoRealArray[i, j] = new Random().NextDouble() * 2 - 1;
            newTwoRealArray[i, j] *= arg1; 
        }
    }
    return newTwoRealArray;
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:f2}\t      ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

Console.Write("Enter count of rows m: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter count of lines n: ");
int lines = int.Parse(Console.ReadLine());
Console.Write("Enter count of variable: ");
int var = int.Parse(Console.ReadLine());

double[,] arrayTemp = TwoRealArray(rows, lines, var);
Console.WriteLine();
PrintArray(arrayTemp);


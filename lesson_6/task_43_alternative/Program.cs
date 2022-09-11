// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] FillArrayMassive(int b1, int k1, int b2, int k2)
{
    double[,] array = new double[2,2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[0, 0] = b1;
            array[0, 1] = k1;
            array[1, 0] = b2;
            array[1, 1] = k2;
        }
    }
    return array;
}

void SearchLines(double[,] myarray)
{
    double valuePoint1 = 0;
    double valuePoint2 = 0;
    valuePoint1 = (myarray[1, 0] - myarray[0, 0]) / (myarray[0, 1] - myarray[1, 1]);
    valuePoint2 = myarray[0, 1] * valuePoint1 + myarray[0, 0];
    Console.Write($"Points of intersection of straight lines: ({valuePoint1:f1}; {valuePoint2:f1})");
}

Console.Write("Enter value b1: ");
int numb1 = int.Parse(Console.ReadLine());
Console.Write("Enter value k1: ");
int numk1 = int.Parse(Console.ReadLine());
Console.Write("Enter value b2: ");
int numb2 = int.Parse(Console.ReadLine());
Console.Write("Enter value k2: ");
int numk2 = int.Parse(Console.ReadLine());

double[,] matrix1 = FillArrayMassive(numb1, numk1, numb2, numk2);
Console.WriteLine();

PrintArray(matrix1);
Console.WriteLine();

void FinalyValue(int numb1, int numk1, int numb2, int numk2)
{
    if (numb1 == numb2 && numk1 == numk2) Console.WriteLine("Lines intersect");
    else if (numk1 == numk2) Console.WriteLine("Lines parallel");
    else
    {
        SearchLines(matrix1);
    }
    Console.WriteLine();
}

FinalyValue(numb1, numk1, numb2, numk2);

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

void FillArray(double[,] array2x2)
{
    Console.Write("Enter value b1: ");
    double numb1 = double.Parse(Console.ReadLine());
    Console.Write("Enter value k1: ");
    double numk1 = double.Parse(Console.ReadLine());
    Console.Write("Enter value b2: ");
    double numb2 = double.Parse(Console.ReadLine());
    Console.Write("Enter value k2: ");
    double numk2 = double.Parse(Console.ReadLine());

    if(numk1 == numk2 && numb1 == numb2) Console.WriteLine("Lines intersect");
    else if(numk1 == numk2) Console.WriteLine("Lines parralel");
    else
    {    
        for (int i = 0; i < array2x2.GetLength(0); i++)
        {
            for (int j = 0; j < array2x2.GetLength(1); j++)
            {
                array2x2[0, 0] = numb1;
                array2x2[0, 1] = numk1;
                array2x2[1, 0] = numb2;
                array2x2[1, 1] = numk2;
            }
        }
    }
}

void SearchLines(double[,] myarray)
{
    double valuePoint1 = 0;
    double valuePoint2 = 0;
    valuePoint1 = (myarray[1, 0] - myarray[0, 0]) / (myarray[0, 1] - myarray[1, 1]);
    valuePoint2 = myarray[0, 1] * valuePoint1 + myarray[0, 0];
    Console.Write($"Points of intersection of straight lines: ({valuePoint1:f1}; {valuePoint2:f1})");
}

double[,] matrix = new double[2, 2];

FillArray(matrix);
Console.WriteLine();

PrintArray(matrix);
Console.WriteLine();

SearchLines(matrix);
Console.WriteLine();


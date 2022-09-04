// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] NumbersR(int size, double arg1)
{
    double[] arrayR = new double[size];
    for (int j = 0; j < arrayR.Length; j++)
    {
        arrayR[j] = new Random().NextDouble();
        arrayR[j] *= arg1;
    }
    return arrayR;
}

void PrintArray1(double[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]:f}, ");
    }
    Console.WriteLine();
}

double SearchMax(double[] arrayR1)
{
    double max = arrayR1[0];
    for (int k = 1; k < arrayR1.Length; k++)
    {
        if(arrayR1[k] > max)
        {
            max = arrayR1[k];
        }
    }
    return max;
}

double SearchMin(double[] arrayR2)
{
    double min = arrayR2[0];
    for (int c = 1; c < arrayR2.Length; c++)
    {
        if(arrayR2[c] < min)
        {
            min = arrayR2[c];
        }
    }
    return min;
}



Console.Write("Enter size of array: ");
int sizeEl = int.Parse(Console.ReadLine());
Console.Write("Enter size of number multiple of 10: ");
double sizeNum = double.Parse(Console.ReadLine());

double[] myArray = NumbersR(sizeEl, sizeNum);
PrintArray1(myArray);
Console.WriteLine();

Console.WriteLine($"Out max: {SearchMax(myArray):f}");
Console.WriteLine($"Out min: {SearchMin(myArray):f}");
Console.WriteLine();

Console.WriteLine($"Difference max and min: {SearchMax(myArray) - SearchMin(myArray):f}");

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElementInSegment(int m, int n)
{
    if (m > n) return 0;
    return m + SumElementInSegment(++m, n);
}

int SumElementInSegmentTiny(int m, int n)
{
    return m > n ? 0 : m + SumElementInSegment(++m, n);
}


Console.Write("Enter the number m: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Enter the number n: ");
int numN = int.Parse(Console.ReadLine());
int sumNum = SumElementInSegmentTiny(numM, numN);
Console.WriteLine("-----------------------------");
Console.Write($"Sum numbers in the segment = {sumNum}.");
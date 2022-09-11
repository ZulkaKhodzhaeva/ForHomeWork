// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] NewArray(int size, int begin, int end)
{
    int[] massive = new int[size];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(begin, end);
    }
    return massive;
}

void PrintArray1(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]}, ");
    }
    Console.WriteLine();
}

void SumOdd(int[] arg1)
{
    int sum = 0;
    for (int i = 0; i < arg1.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += arg1[i];
        }
        Console.Write($"{arg1[i]}, ");
    }
    Console.WriteLine();
    Console.WriteLine($"Sum of odd array elements: {sum}");
}

//Console.WriteLine(String.Join(", ", NewArray(9)));

// int[] arg1 = NewArray(5);
Console.Write("Enter size of array: ");
int sizeEl = int.Parse(Console.ReadLine());
Console.Write("Enter begin of array: ");
int numBegin = int.Parse(Console.ReadLine());
Console.Write("Enter end of array: ");
int numEnd = int.Parse(Console.ReadLine());

SumOdd(NewArray(sizeEl, numBegin, numEnd));

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] NewArrayPositive(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void PrintQuantityEven(int[] array1)
{
    int temp = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i] % 2 == 0)
        {
            temp ++;
        }
        else
        {
            temp += 0;
        }
        Console.Write($"{array1[i]}, ");
    }
    Console.WriteLine();
    Console.Write($"The count of even numbers: {temp}");
}

Console.Write("Enter size of array: ");
int sizeArray = int.Parse(Console.ReadLine());
//Console.WriteLine(string.Join(", ", NewArrayPositive(sizeArray)));
PrintQuantityEven(NewArrayPositive(sizeArray));

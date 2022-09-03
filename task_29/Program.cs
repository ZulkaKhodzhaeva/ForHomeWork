// Задача 29: Напишите программу, которая задаёт массив из N элементов, 
// заполненных случайнми числами из [a, b) и выводит их на экран.

// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]


int[] GetArray(int num, int alpha, int omega)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(alpha, omega);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");        
    }
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

Console.Write("Введите начало полуинтервала: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите конец полуинтервала: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Полученный массив чисел: {String.Join(", ", GetArray(size, num1, num2))}");
//PrintArray(GetArray(size, num1, num2));
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int PositiveNumbers(int[] array)
{
    int sumNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) 
        {
            sumNumbers++;
        }
    }
    return sumNumbers;
}

int[] GetArray(int size, int alpha, int omega)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(alpha, omega);
    }
    return array;
}

int SearchPositiveNums(int numbers)
{
    int sumCount = 0;
    for (int i = 0; i < numbers; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        int nums = int.Parse(Console.ReadLine());
        if (nums > 0) sumCount++;
    }
    return sumCount;
}

Console.Write("Введите желаемое количество чисел: ");
int countNumbers = int.Parse(Console.ReadLine());
Console.WriteLine();
int newNums = SearchPositiveNums(countNumbers);
Console.WriteLine();
Console.WriteLine($"Положительных чисел: {newNums}");

                                // // Способ при использовании фиксированного количества чисел (числа задаются пользователем).

// Console.WriteLine("Введите 5 любых целых чисел (разделитель ", "): ");
// string[] naturalNums = Console.ReadLine().Split(", ");
// int num1 = int.Parse(naturalNums[0]);
// int num2 = int.Parse(naturalNums[1]);
// int num3 = int.Parse(naturalNums[2]);
// int num4 = int.Parse(naturalNums[3]);
// int num5 = int.Parse(naturalNums[4]);
// int[] myArray = {num1, num2, num3, num4, num5};
// int sumPositiveNumbers = PositiveNumbers(myArray);

// Console.WriteLine($"Count of positive numbers: {sumPositiveNumbers}");

                                // // Способ при использовании параметров задаваемых пользователем (размер, начало и конец массива),
                                // // массив при этом рандомный.

// Console.Write("Введите размер массива: ");
// int sizeArray = int.Parse(Console.ReadLine());
// Console.Write("Введите начало массива: ");
// int beginArray = int.Parse(Console.ReadLine());
// Console.Write("Введите конец массива: ");
// int endArray = int.Parse(Console.ReadLine());
// Console.WriteLine();
// int[] newRandomArray = GetArray(sizeArray, beginArray, endArray);
// Console.WriteLine(string.Join(", ", newRandomArray));
// Console.WriteLine();
// int sum = PositiveNumbers(newRandomArray);
// Console.WriteLine($"Count of positive numbers: {sum}");

                                            // // Способ без использования методов и массивов.

// Console.WriteLine("Введите 5 чисел: ");
// string[] naturalNums = Console.ReadLine().Split(", ");
// int num1 = int.Parse(naturalNums[0]);
// int num2 = int.Parse(naturalNums[1]);
// int num3 = int.Parse(naturalNums[2]);
// int num4 = int.Parse(naturalNums[3]);
// int num5 = int.Parse(naturalNums[4]);

// int sumPositive = 0;
// if(num1 > 0) sumPositive++;
// if(num2 > 0) sumPositive++;
// if(num3 > 0) sumPositive++;
// if(num4 > 0) sumPositive++;
// if(num5 > 0) sumPositive++;
// Console.WriteLine(sumPositive);




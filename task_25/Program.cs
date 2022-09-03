// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NumPow(int numA, int numB)
{
    int result = 0;
    int temp = numA;
    for (int count = 1; count < numB; count++)
    {
        result = temp * numA;
        Console.Write($"{result},  ");
        temp = result;
    }
    return temp;
}

Console.WriteLine("Введите число А: ");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int secondNum = int.Parse(Console.ReadLine());

int add = NumPow(firstNum, secondNum);
Console.WriteLine();
Console.WriteLine($"Произведение числа А после возведения в натуральную степень числа B: {add}");

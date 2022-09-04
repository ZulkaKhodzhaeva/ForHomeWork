// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double NumPow(double numA, double numB)
{
    double result = 0;
    double temp = numA;
    for (double count = 1; count < numB; count++)
    {
        result = temp * numA;
        Console.Write($"{result},  ");
        temp = result;
    }
    return temp;
}

Console.WriteLine("Введите число А: ");
double firstNum = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
double secondNum = double.Parse(Console.ReadLine());

double add = NumPow(firstNum, secondNum);
Console.WriteLine();
Console.WriteLine($"Произведение числа А после возведения в натуральную степень числа B: {add}");


// я намеренно изменила тип из int в double, чтобы не получать отрицательные числа при большой степени возведения числа А.
// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumber(int number)
{
    int sum = 0;
    int result = 0;
    while (number != 0)
    {
        result = number % 10;
        number = number / 10;
        sum = sum + result;
    }
    return sum;
}

Console.WriteLine("Введите любое натуральное число: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе равна: {SumNumber(numA)}");

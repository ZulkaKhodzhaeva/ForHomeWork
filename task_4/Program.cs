// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22 

//Первый способ
// Console.WriteLine("Введите первое число: ");
// int firstNumber = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int secondNumber = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите третье число: ");
// int thirdNumber = int.Parse(Console.ReadLine());

// if(firstNumber > secondNumber & firstNumber > thirdNumber)
// {
//     // if(firstNumber > thirdNumber)                                                                                   
//     Console.WriteLine("Максимальное число равно: ");
//     Console.WriteLine(firstNumber);
// }
// else
//     {
//         if(secondNumber > thirdNumber)
//         {
//             Console.WriteLine("Максимальное число равно: ");
//             Console.WriteLine(secondNumber);
//         }
//         else
//         {
//             Console.WriteLine("Максимальное число равно: ");
//             Console.WriteLine(thirdNumber);
//         }
//     }


//второй способ
Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine());

if(firstNumber > secondNumber)
{
    if(firstNumber > thirdNumber)
    {
        Console.Write($"Максимальное число равно: {firstNumber}");
        // Console.WriteLine(firstNumber);
    }
    else
    {
        Console.Write($"Максимальное число равно: {thirdNumber}");
    }
}
else
{
    if(secondNumber > thirdNumber)
    {
        Console.Write($"Максимальное число равно: {secondNumber}");
    }
    else
    {
        Console.Write($"Максимальное число равно: {thirdNumber}");
    }
}
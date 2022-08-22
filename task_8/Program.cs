// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите любое число число: ");
int N = int.Parse(Console.ReadLine());
int first = 2;

while(first <= N)
{
    Console.WriteLine(first);
    first += 2;
}

// Напшите программу, которая принимает на вход число (N) и 
// выдает таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите любое положительное число: ");
int newnumb = int.Parse(Console.ReadLine());
int count = 1;

if(newnumb < 0)
{
    Console.WriteLine("Введенное значение отрицательное");
}
else
{
    while(count <= newnumb)
    {
        double cube = Math.Pow(count, 3);
        Console.Write($"{cube} ");
        count++;
    }
}
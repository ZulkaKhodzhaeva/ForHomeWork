// Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите любое число: ");
int run = int.Parse(Console.ReadLine());

int num1 = (run / 100) % 10;

if(num1 == 0)
{
    Console.WriteLine("Третьей цифры заданного числа не существует");
}
else
{
    Console.WriteLine($"Третья цифра числа = {num1}");
}
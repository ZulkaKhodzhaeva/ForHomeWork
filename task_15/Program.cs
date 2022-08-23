// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, 
// является ли этот день выходным

// Console.WriteLine("Введите любое число от 1 до 7: ");
// int days = int.Parse(Console.ReadLine());

// if(0 < days && days < 8)
// {
//     if(days == 1) Console.WriteLine("Понедельник");
//     else if(days == 2) Console.WriteLine("Вторник");
//     else if(days == 3) Console.WriteLine("Среда");
//     else if(days == 4) Console.WriteLine("Четверг");
//     else if(days == 5) Console.WriteLine("Пятница");
//     else if(days == 6) Console.WriteLine("Выходной день суббота");
//     else if(days == 7) Console.WriteLine("Выходной день воскресенье");
// }
// else
// {
//     Console.WriteLine("Введенное число не соответствует параметрам условия.");
// }


Console.WriteLine("Введите любое число от 1 до 7: ");
int days = int.Parse(Console.ReadLine());

if(0 < days && days < 8)
{
    if(0 < days && days < 6) Console.WriteLine("Будний день");
    else if(5 < days && days < 8) Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Введенное число не соответствует параметрам условия.");
}
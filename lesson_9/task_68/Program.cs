// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

int Akrm(int num, int arg)
{
    if (num == 0) return arg + 1;
    else if (num > 0 & arg == 0) return Akrm(num - 1 , 1);
    else return Akrm(num - 1, Akrm(num, arg - 1));
}

Console.Write("Enter the number m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter the argument n: ");
int n = int.Parse(Console.ReadLine());

int akkerman = Akrm(m, n);
Console.WriteLine($"The Akkerman function numbers {m} and arguments {n} = {akkerman}");
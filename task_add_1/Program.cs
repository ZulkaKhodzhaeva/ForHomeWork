// Задача “со звездочкой”: Напишите функцию, которая принимает одно число
//  - высоту елочки и рисует ее в консоли звездочками.



Console.WriteLine("Введите количество ярусов: ");
int height = int.Parse(Console.ReadLine());
int alt = 40;
string symbol = "*".PadLeft(alt);
for (int i = 0; i < height; i++)
{
    alt = alt - 10;
    Console.WriteLine(symbol);
    symbol += "**";
    
}

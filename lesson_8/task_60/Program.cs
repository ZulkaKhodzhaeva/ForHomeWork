// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] TresArray(int heightArray, int widthArray, int depthArray)
{
    int[,,] newTresArray = new int[heightArray, widthArray, depthArray];
    int number = 10;
    for (int i = 0; i < newTresArray.GetLength(0); i++)
    {
        for (int j = 0; j < newTresArray.GetLength(1); j++)
        {
            for (int k = 0; k < newTresArray.GetLength(2); k++)
            {
                newTresArray[j, k, i] = number;
                number += 3;
            }
        }
    }
    return newTresArray;
}

void PrintArray(int[,,] matr)
{
    int count = 1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[j, k, i]} ({j}, {k}, {i})\t");
                count++;
            }
            Console.WriteLine();
        }
    }
}



Console.Write("Enter count of height array: ");
int height = int.Parse(Console.ReadLine());
Console.Write("Enter count of width array: ");
int width = int.Parse(Console.ReadLine());
if(height != width) 
{
    Console.WriteLine("Enter to coorect value!");
    return;
}
Console.Write("Enter count of depth array: ");
int depth = int.Parse(Console.ReadLine());
if(height != depth) 
{
    Console.WriteLine("Enter to coorect value!");
    return;
}
Console.WriteLine("********************************************");

int[,,] arrayMatrix = TresArray(height, width, depth);
PrintArray(arrayMatrix);


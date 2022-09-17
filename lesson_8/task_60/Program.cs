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
                newTresArray[i, j, k] = number;
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
                Console.Write($"{matr[i, j, k]} ({i}, {j}, {k})\t");
                count++;
            }
            Console.WriteLine();
        }
    }
}



// Console.Write("Enter count of rows: ");
// int rowsArray = int.Parse(Console.ReadLine());
// Console.Write("Enter count of lines = rows: ");
// int linesArray = int.Parse(Console.ReadLine());
// if(rowsArray != linesArray)
// {
//     Console.WriteLine("Enter correct value!");
//     return;
// }
// Console.Write("Enter beginning of the segment: ");
// int beginSegment = int.Parse(Console.ReadLine());
// Console.Write("Enter end of the segment: ");
// int endSegment = int.Parse(Console.ReadLine());
// Console.WriteLine("********************************************");

int[,,] arrayMatrix = TresArray(2, 2, 2);                                               //(beginSegment, endSegment, linesArray, rowsArray);
PrintArray(arrayMatrix);


/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

void FillArray2D(int[,] array2D)
{
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintArray2D(int[,] array2D)
{
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void NewArray2D(int[,] array2D)
{
    int[] row = new int[array2D.GetLength(1)];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            row[j] = array2D[i, j];
        }
        Array.Sort(row);
        Array.Reverse(row);

        for (int k = 0; k < array2D.GetLength(1); k++)
        {
            array2D[i, k] = row[k];
        }
    }
}

int[,] array2D = new int[3, 4];
FillArray2D(array2D);
PrintArray2D(array2D);
Console.WriteLine();
NewArray2D(array2D);
PrintArray2D(array2D);

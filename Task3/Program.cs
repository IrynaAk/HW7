// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив: 
//1 4 7 2 
//5 9 2 3 
//8 4 2 4 Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;

Clear();

WriteLine("Please type number rows and columns with a space: ");
string[] rowColumn = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int row = int.Parse(rowColumn[0]);
int column = int.Parse(rowColumn[1]);
int[,] myArray = GetRandomArray(row,column);
PrintArray(myArray);
WriteLine();
double[] average = GetAverage(myArray);
PrintArray2(average);


double[] GetAverage(int[,] arr)

{
    double[] result = new double[arr.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
        {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
           result[i] += arr[j,i];
        }
        result[i] = result[i]/arr.GetLength(0);
    }
    return result;

}

int[,] GetRandomArray(int rows, int columns)
{
    int[,] result = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(0,10);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j] } ");
        }
        WriteLine();
    }
}

void PrintArray2 (double[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Write($"{array2[i].ToString("F2")}, ");
    }
}



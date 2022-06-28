// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

using System;
using static System.Console;

Clear();

int[,] myArray = GetRandomArray(5,5);
WriteLine("Please add position (row number, column number with a space: ");
string[] arraySize = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
int row = int.Parse(arraySize[0]);
int column = int.Parse(arraySize[1]);

if(row<= myArray.GetLength(0) || column<=myArray.GetLength(1))
{WriteLine($"Element value is: {myArray[row,column]}");}
else
{ WriteLine("There is no such position in the array");}

PrintArray(myArray);


int[,] GetRandomArray(int rows, int columns)
{
    int[,] result = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(-10,10);
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